using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using commercetools.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public static class ClientInjectionSetup
    {
        /// <summary>
        /// Inject Scoped Client per each Request
        /// </summary>
        /// <param name="services">services container</param>
        /// <param name="configuration"></param>
        /// <param name="clientName"></param>
        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsScopedClient(this IServiceCollection services,
            IConfiguration configuration,
            string clientName)
        {
            services.UseCommercetoolsApiSerialization();
            //Create Client with AnonymousTokenProvider, Inject it as scoped service
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            
            services.AddScoped(serviceProvider =>
            {
                var anonymousId = Guid.NewGuid().ToString();
                var httpContextAccessor = serviceProvider.GetService<IHttpContextAccessor>();
                var anonymousIdStore = new InCookiesAnonymousCredentialsStoreManager(anonymousId, httpContextAccessor);
                var client = ClientFactory.Create(clientName, clientConfiguration,
                    serviceProvider.GetService<IHttpClientFactory>(),
                    serviceProvider.GetService<SerializerService>(),
                    CreateAnonymousTokenProvider(clientName, configuration, serviceProvider, anonymousIdStore));
                client.Name = clientName;
                return client;
            });
            var builders = new ConcurrentDictionary<string, IHttpClientBuilder>();
            builders.TryAdd(clientName, services.SetupClient(clientName, 
                errorTypeMapper => typeof(ErrorResponse), 
                serviceProvider => serviceProvider.GetService<SerializerService>()));
            return builders;
        }
        
        public static ITokenProvider CreateAnonymousTokenProvider(string clientName, 
            IConfiguration configuration, 
            IServiceProvider serviceProvider, 
            IAnonymousCredentialsStoreManager anonymousStore)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateAnonymousSessionTokenProvider(
                clientConfiguration, httpClientFactory, anonymousStore);
        }
    }
}