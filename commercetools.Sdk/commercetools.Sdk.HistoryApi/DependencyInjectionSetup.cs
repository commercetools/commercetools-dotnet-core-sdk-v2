using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.HistoryApi.Client;
using commercetools.Sdk.HistoryApi.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.HistoryApi
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsHistoryApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.HistoryApi,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier = null,
            ClientOptions options = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => HistoryApiFactory.Create(c.GetService<IClient>()));
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            if (clientConfiguration.ProjectKey != null)
            {
                services.AddSingleton(c => HistoryApiFactory.Create(c.GetService<IClient>(), clientConfiguration.ProjectKey));
            }

            return services.UseCommercetoolsHistoryApi(configuration, clients, tokenProviderSupplier ?? CreateDefaultTokenProvider, options).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsHistoryApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier,
            ClientOptions options = null)
        {
            services.AddSingleton(configuration);
            services.UseCommercetoolsHistoryApiSerialization();
            clients.ToList().ForEach(clientName =>
            {
                IClientConfiguration clientConfiguration =
                    configuration.GetSection(clientName).Get<ClientConfiguration>();
                services.AddSingleton(c => HistoryApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            });

            return services.UseHttpApi(configuration, clients,
                serviceProvider => serviceProvider.GetService<IHistorySerializerService>(),
                message => typeof(Object),
                tokenProviderSupplier ?? CreateDefaultTokenProvider);
        }

        public static void UseCommercetoolsHistoryApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<SerializerService>();
            services.AddSingleton<IHistorySerializerService, SerializerService>();
        }

        public static ITokenProvider CreateDefaultTokenProvider(string clientName, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateClientCredentialsTokenProvider(clientConfiguration, httpClientFactory);
        }
    }
}