using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Client;
using commercetools.Base.Registration;
using commercetools.Base.Serialization;
using commercetools.Sdk.ML.Client;
using commercetools.Sdk.ML.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.ML
{
    public static class DependencyInjectionSetup
    {
        public static IHttpClientBuilder UseCommercetoolsMLApi(this IServiceCollection services,
            IConfiguration configuration,
            string clientName = DefaultClientNames.MLApi)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => MLApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsMLApi(configuration, clients).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsMLApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients)
        {
            services.UseCommercetoolsMLApiSerialization();
            return services.UseHttpApi(configuration, clients, c => c.GetService<SerializerService>());
        }

        public static void UseCommercetoolsMLApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<SerializerService>();
        }
    }
}