using System;
using System.Net.Http;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.NewRelicExample.Extensions
{
    public static class ClientInjectionSetup
    {
        /// <summary>
        /// Inject Scoped Client per each Request
        /// </summary>
        /// <param name="services">services container</param>
        /// <param name="configuration"></param>
        /// <param name="clientName"></param>
        public static IHttpClientBuilder UseCommercetoolsScopedClient(this IServiceCollection services,
            IConfiguration configuration,
            string clientName)
        {
            services.UseCommercetoolsApiSerialization();
            services.UseScopedCredentialsStoreManagers(clientName, configuration);
            services.UseScopedTokenProvider(clientName, configuration);

            //Create Client with proper TokenProvider as scoped service
            services.AddScoped(serviceProvider =>
            {
                var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
                var tokenProvider = serviceProvider.GetService<ITokenProvider>();
                var client = new ClientBuilder()
                {
                    ClientConfiguration = clientConfiguration,
                    ClientName = clientName,
                    TokenProvider = tokenProvider,
                    SerializerService = serviceProvider.GetService<IApiSerializerService>(),
                    HttpClient = serviceProvider.GetService<IHttpClientFactory>().CreateClient(clientName)
                }.Build();
                client.Name = clientName;
                return client;
            });

            //Add the httpClient and setup the Middlewares
            return services.SetupClient(clientName,
                errorTypeMapper => typeof(ErrorResponse),
                serviceProvider => serviceProvider.GetService<IApiSerializerService>());
        }


        /// <summary>
        /// Inject two instance, one for IAnonymousCredentialsStoreManager and other for IUserCredentialsStoreManager
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientName"></param>
        /// <param name="configuration"></param>
        public static void UseScopedCredentialsStoreManagers(this IServiceCollection services,
            string clientName,
            IConfiguration configuration)
        {
            services.AddScoped<IAnonymousCredentialsStoreManager>(serviceProvider =>
            {
                var inCookiesStoreManager = serviceProvider.GetService<InCookiesStoreManager>();
                var inSessionStoreManager = serviceProvider.GetService<InSessionStoreManager>();
                var anonymousIdStore = new InSessionAnonymousCredentialsStoreManager(inSessionStoreManager, inCookiesStoreManager);
                return anonymousIdStore;
            });
            services.AddScoped<IUserCredentialsStoreManager>(serviceProvider =>
            {
                var inCookiesStoreManager = serviceProvider.GetService<InCookiesStoreManager>();
                var inSessionStoreManager = serviceProvider.GetService<InSessionStoreManager>();
                var userCredentialsStore = new InSessionUserCredentialsStoreManager(inSessionStoreManager, inCookiesStoreManager);
                return userCredentialsStore;
            });
        }

        /// <summary>
        /// Inject scoped tokenProvider based on current tokenFlow
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientName"></param>
        /// <param name="configuration"></param>
        public static void UseScopedTokenProvider(this IServiceCollection services,
            string clientName,
            IConfiguration configuration)
        {
            services.AddScoped(serviceProvider =>
            {
                var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
                var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
                var currentTokenFlow = GetCurrentTokenFlow(serviceProvider);
                ITokenProvider tokenProvider = null;
                if (currentTokenFlow == TokenFlow.Password)
                {
                    var userCredentialsStore = serviceProvider.GetService<IUserCredentialsStoreManager>();
                    tokenProvider = TokenProviderFactory.CreatePasswordTokenProvider(
                        clientConfiguration, httpClientFactory, userCredentialsStore);
                }
                else
                {
                    var anonymousIdStore = serviceProvider.GetService<IAnonymousCredentialsStoreManager>();
                    if (anonymousIdStore != null && anonymousIdStore.Token == null)
                    {
                        anonymousIdStore.AnonymousId = Guid.NewGuid().ToString();
                    }
                    tokenProvider = TokenProviderFactory.CreateAnonymousSessionTokenProvider(
                        clientConfiguration, httpClientFactory, anonymousIdStore);
                }
                return tokenProvider;
            });
        }

        public static TokenFlow GetCurrentTokenFlow(IServiceProvider serviceProvider)
        {
            var tokenFlow = TokenFlow.AnonymousSession;
            var userCredentialsStore = serviceProvider.GetService<IUserCredentialsStoreManager>();
            if (userCredentialsStore != null && !string.IsNullOrEmpty(userCredentialsStore.Username))
            {
                tokenFlow = TokenFlow.Password;
            }
            return tokenFlow;
        }
    }
}