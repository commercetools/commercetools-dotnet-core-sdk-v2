using commercetools.Api.Models.Types;
using commercetools.Api.Serialization;
using commercetools.Base.Serialization.Mappers;
using commercetools.Api.Serialization.Mappers.CustomFieldMappers;
using commercetools.Api.Serialization.MapperTypeRetrievers;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using Microsoft.Extensions.Configuration;

namespace commercetools.Api
{
    public static class DependencyInjectionSetup
    {
        /// <summary>
        /// Adds concrete implementations necessary for running of the application to the service collection for a single client.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="clientName">The name of the client.</param>
        /// <param name="tokenFlow">The token flow.</param>
        public static IHttpClientBuilder UseCommercetoolsApi(this IServiceCollection services, IConfiguration configuration, string clientName = DefaultClientNames.Api, TokenFlow tokenFlow = TokenFlow.ClientCredentials)
        {
            var clients = new ConcurrentDictionary<string, TokenFlow>();
            clients.TryAdd(clientName, tokenFlow);
            return services.UseCommercetoolsApi(configuration, clients).Single().Value;
        }

        /// <summary>
        /// Adds concrete implementations necessary for running of the application to the service collection for multiple client.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="clients">The clients with the client name as the key and the token flow as they value.</param>
        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsApi(this IServiceCollection services, IConfiguration configuration, IDictionary<string, TokenFlow> clients)
        {
            services.UseCommercetoolsApiSerialization();
            return services.UseHttpApi(configuration, clients);
        }

        public static void UseCommercetoolsApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<ICustomJsonMapper<FieldContainer>, StringFieldMapper>();
            services.AddSingleton<ICustomJsonMapper<FieldContainer>, NumberFieldMapper>();
            services.AddSingleton<IMapperTypeRetriever<FieldContainer>, FieldMapperTypeRetriever>();
            services.AddSingleton<SerializerService>();
        }
    }
}