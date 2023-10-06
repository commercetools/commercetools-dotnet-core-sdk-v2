using System;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Serialization;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.Configuration;

namespace commercetools.Sdk.Api
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.Api,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier = null,
            ISerializationConfiguration serializationConfiguration = null,
            ClientOptions options = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => ApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName)));
            IClientConfiguration clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            if (clientConfiguration.ProjectKey != null)
            {
                services.AddSingleton(c => ApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            }
            return services.UseCommercetoolsApi(configuration, clients,
                tokenProviderSupplier ?? CreateDefaultTokenProvider, serializationConfiguration, options).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients,
            Func<string, IConfiguration, IServiceProvider, ITokenProvider> tokenProviderSupplier = null,
            ISerializationConfiguration serializationConfiguration = null,
            ClientOptions options = null)
        {
            services.UseCommercetoolsApiSerialization(serializationConfiguration);

            clients.ToList().ForEach(clientName =>
            {
                IClientConfiguration clientConfiguration =
                    configuration.GetSection(clientName).Get<ClientConfiguration>();
                services.AddSingleton(c => ApiFactory.Create(c.GetServices<IClient>().Single(client => client.Name == clientName), clientConfiguration.ProjectKey));
            });

            return services.UseHttpApi(configuration, clients,
                serviceProvider => serviceProvider.GetService<IApiSerializerService>(),
                message => typeof(ErrorResponse),
                tokenProviderSupplier ?? CreateDefaultTokenProvider,
                options);
        }

        public static void UseCommercetoolsApiSerialization(this IServiceCollection services,
            ISerializationConfiguration serializationConfiguration = null)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton(serializationConfiguration ?? SerializationConfiguration.DefaultConfig);
            services.AddSingleton<IMapperTypeRetriever<IFieldContainer>>(new FieldMapperTypeRetriever());
            services.AddSingleton<IMapperTypeRetriever<IAttribute>>(new AttributeMapperTypeRetriever());
            services.AddSingleton(new AttributeTypeRetriever());
            services.AddSingleton<SerializerService>();
            services.AddSingleton<IApiSerializerService, SerializerService>();
        }

        public static ITokenProvider CreateDefaultTokenProvider(string clientName, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateClientCredentialsTokenProvider(clientConfiguration, httpClientFactory);
        }
    }
}