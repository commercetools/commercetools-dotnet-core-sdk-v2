using System;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.Mappers;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Serialization;
using commercetools.Sdk.Api.Serialization.Mappers.CustomFieldMappers;
using commercetools.Sdk.Api.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.Configuration;

namespace commercetools.Sdk.Api
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.Api,
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => ApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsApi(configuration, clients, 
                tokenProviderSupplier ?? CreateDefaultTokenProvider).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients, 
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier = null)
        {
            services.AddSingleton(configuration);
            services.UseCommercetoolsApiSerialization();
            return services.UseHttpApi(configuration, clients, 
                serviceProvider => serviceProvider.GetService<ISerializerService>(), 
                tokenProviderSupplier ?? CreateDefaultTokenProvider);
        }

        public static void UseCommercetoolsApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<ICustomJsonMapper<IFieldContainer>, StringFieldMapper>();
            services.AddSingleton<ICustomJsonMapper<IFieldContainer>, NumberFieldMapper>();
            services.AddSingleton<IMapperTypeRetriever<IFieldContainer>, FieldMapperTypeRetriever>();
            services.AddSingleton<ISerializerService,SerializerService>();
        }

        public static ITokenProvider CreateDefaultTokenProvider(string clientName, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var clientConfiguration = configuration.GetSection(clientName).Get<ClientConfiguration>();
            return TokenProviderFactory.CreateClientCredentialsTokenProvider(clientConfiguration, httpClientFactory);
        }
    }
}