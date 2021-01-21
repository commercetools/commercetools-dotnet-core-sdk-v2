using commercetools.Base.Serialization.Mappers;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Client;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client;
using commercetools.Sdk.ImportApi.Serialization;
using Microsoft.Extensions.Configuration;

namespace commercetools.Sdk.ImportApi
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsImportApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.ImportApi)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => ImportApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsImportApi(configuration, clients).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsImportApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients)
        {
            services.UseCommercetoolsImportApiSerialization();
            return services.UseHttpApi(configuration, clients, c => c.GetService<SerializerService>());
        }

        public static void UseCommercetoolsImportApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<SerializerService>();
        }
    }
}