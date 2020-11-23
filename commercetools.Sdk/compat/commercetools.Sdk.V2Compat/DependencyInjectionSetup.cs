using commercetools.Sdk.Serialization;
using commercetools.Sdk.V2Compat.JsonConverters;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.V2Compat
{
    public static class DependencyInjectionSetup
    {
        public static void UseCommercetoolsCompatLayer(this IServiceCollection services)
        {
            services.AddSingleton(typeof(JsonConverterBase), typeof(DeserializeAsConverterFactory));
            services.AddSingleton(typeof(JsonConverterBase), typeof(EnumAsInterfaceConverterFactory));
            services.AddSingleton(typeof(JsonConverterBase), typeof(TypeDiscriminatorConverterFactory));
        }
    }
}