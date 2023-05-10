using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Models.Errors;
using commercetools.Sdk.ImportApi.Client;
using commercetools.Sdk.ImportApi.Serialization;
using Microsoft.Extensions.Configuration;

namespace commercetools.Sdk.ImportApi
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsImportApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.ImportApi,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier = null,
            ClientOptions options = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => ImportApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName)));
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            if (clientConfiguration.ProjectKey != null)
            {
                services.AddSingleton(c => ImportApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            }

            return services.UseCommercetoolsImportApi(configuration, clients, tokenProviderSupplier ?? CreateDefaultTokenProvider, options).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsImportApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients, Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier,
            ClientOptions options = null)
        {
            services.UseCommercetoolsImportApiSerialization();
            clients.ToList().ForEach(clientName =>
            {
                IClientConfiguration clientConfiguration =
                    configuration.GetSection(clientName).Get<ClientConfiguration>();
                services.AddSingleton(c => ImportApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            });

            return services.UseHttpApi(configuration, clients,
                serviceProvider => serviceProvider.GetService<IImportSerializerService>(),
                message => typeof(ErrorResponse),
                tokenProviderSupplier ?? CreateDefaultTokenProvider,
                options);
        }

        public static void UseCommercetoolsImportApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<SerializerService>();
            services.AddSingleton<IImportSerializerService, SerializerService>();
        }
        public static ITokenProvider CreateDefaultTokenProvider(string clientName, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateClientCredentialsTokenProvider(clientConfiguration, httpClientFactory);
        }
    }
}