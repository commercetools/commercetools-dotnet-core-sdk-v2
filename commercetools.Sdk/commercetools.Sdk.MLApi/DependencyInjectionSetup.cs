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
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier = null,
            ClientOptions options = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => MLApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName)));
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            if (clientConfiguration.ProjectKey != null)
            {
                services.AddSingleton(c => MLApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            }

            return services.UseCommercetoolsMLApi(configuration, clients, tokenProviderSupplier ?? CreateDefaultTokenProvider, options).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsMLApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier,
            ClientOptions options = null)
        {
            services.AddSingleton(configuration);
            services.UseCommercetoolsMLApiSerialization();
            clients.ToList().ForEach(clientName =>
            {
                IClientConfiguration clientConfiguration =
                    configuration.GetSection(clientName).Get<ClientConfiguration>();
                services.AddSingleton(c => MLApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            });

            return services.UseHttpApi(configuration, clients,
                serviceProvider => serviceProvider.GetService<SerializerService>(),
                message => typeof(Object),
                tokenProviderSupplier ?? CreateDefaultTokenProvider,
                options);
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