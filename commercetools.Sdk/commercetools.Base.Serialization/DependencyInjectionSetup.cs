using commercetools.Base.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Base.Serialization
{
    public static class DependencyInjectionSetup
    {
        public static void UseSerialization(this IServiceCollection services)
        {
            services.AddSingleton<ICultureValidator, CultureValidator>();
        }
    }
}
