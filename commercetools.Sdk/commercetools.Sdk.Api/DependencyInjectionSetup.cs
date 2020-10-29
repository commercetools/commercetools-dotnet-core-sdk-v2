using commercetools.Api.Models.Types;
using commercetools.Api.Serialization;
using commercetools.Base.Serialization.Mappers;
using commercetools.Api.Serialization.Mappers.CustomFieldMappers;
using commercetools.Api.Serialization.MapperTypeRetrievers;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Client;
using commercetools.Base.Client;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using Microsoft.Extensions.Configuration;

namespace commercetools.Api
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.Api)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => ApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsApi(configuration, clients).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients)
        {
            services.UseCommercetoolsApiSerialization();
            return services.UseHttpApi(configuration, clients, c => c.GetService<SerializerService>());
        }

        public static void UseCommercetoolsApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<ICustomJsonMapper<IFieldContainer>, StringFieldMapper>();
            services.AddSingleton<ICustomJsonMapper<IFieldContainer>, NumberFieldMapper>();
            services.AddSingleton<IMapperTypeRetriever<IFieldContainer>, FieldMapperTypeRetriever>();
            services.AddSingleton<SerializerService>();
        }
    }
}