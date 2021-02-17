using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
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
            string clientName = DefaultClientNames.ImportApi,
            Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier = null)
        {
            var clients = new List<string>()
            {
                clientName
            };
            services.AddSingleton(c => ImportApiFactory.Create(c.GetService<IClient>()));
            return services.UseCommercetoolsImportApi(configuration, clients, tokenProviderSupplier).Single().Value;
        }

        public static IDictionary<string, IHttpClientBuilder> UseCommercetoolsImportApi(this IServiceCollection services,
            IConfiguration configuration, IList<string> clients, Func<string, IConfiguration , IServiceProvider, ITokenProvider> tokenProviderSupplier)
        {
            services.UseCommercetoolsImportApiSerialization();
            return services.UseHttpApi(configuration, clients, serviceProvider => serviceProvider.GetService<SerializerService>(), tokenProviderSupplier);
        }

        public static void UseCommercetoolsImportApiSerialization(this IServiceCollection services)
        {
            services.UseRegistration();
            services.UseSerialization();
            services.AddSingleton<SerializerService>();
        }
    }
}