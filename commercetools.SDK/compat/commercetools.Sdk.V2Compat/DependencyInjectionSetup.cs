using commercetools.Sdk.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.V2Compat
{
    public static class DependencyInjectionSetup
    {
        public static void UseCommercetoolsCompatLayer(this IServiceCollection services)
        {
            services.AddSingleton(typeof(JsonConverterBase), typeof(DiscriminatorConverterFactory));
        }
    }
}