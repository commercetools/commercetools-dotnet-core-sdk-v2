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
        public static IHttpClientBuilder UseCommercetoolsApi(this IServiceCollection services, IConfiguration configuration,
            string clientName = DefaultClientNames.Api)
        {
            var clients = new List<string>()
            {
                clientName
            };
            return services.UseCommercetoolsApi(configuration, clients).Single().Value;
        }
        
        /// <summary>
        /// Adds concrete implementations necessary for running of the application to the service collection for a single client.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        /// <param name="clientName">The name of the client.</param>
        /// <param name="tokenFlow">The token flow.</param>
        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsApi(this IServiceCollection services, IConfiguration configuration, IList<string> clients)
        {
            services.UseCommercetoolsApiSerialization();
            return services.UseHttpApi(configuration, clients, c => c.GetService<SerializerService>());
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