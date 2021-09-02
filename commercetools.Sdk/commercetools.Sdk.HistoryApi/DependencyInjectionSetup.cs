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
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => HistoryApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsHistoryApi(configuration, clients, tokenProviderSupplier ?? CreateDefaultTokenProvider).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsHistoryApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier)
        {
            services.AddSingleton(configuration);
            services.UseCommercetoolsHistoryApiSerialization();
            return services.UseHttpApi(configuration, clients,
                serviceProvider => serviceProvider.GetService<SerializerService>(),
                message => typeof(Object),
                tokenProviderSupplier ?? CreateDefaultTokenProvider);
        }

        public static void UseCommercetoolsHistoryApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<SerializerService>();
        }

        public static ITokenProvider CreateDefaultTokenProvider(string clientName, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateClientCredentialsTokenProvider(clientConfiguration, httpClientFactory);
        }
    }
}