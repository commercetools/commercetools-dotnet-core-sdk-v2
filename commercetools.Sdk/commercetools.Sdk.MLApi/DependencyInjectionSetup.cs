using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.MLApi.Client;
using commercetools.Sdk.MLApi.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.MLApi
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsMLApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.MLApi,
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => MLApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsMLApi(configuration, clients, tokenProviderSupplier ?? CreateDefaultTokenProvider).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsMLApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients, 
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier)
        {
            services.UseCommercetoolsMLApiSerialization();
            return services.UseHttpApi(configuration, clients, 
                serviceProvider => serviceProvider.GetService<SerializerService>(), 
                tokenProviderSupplier ?? CreateDefaultTokenProvider);
        }

        public static void UseCommercetoolsMLApiSerialization(this IServiceCollection services)
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