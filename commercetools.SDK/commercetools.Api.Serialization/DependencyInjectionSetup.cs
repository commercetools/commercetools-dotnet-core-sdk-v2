using Microsoft.Extensions.DependencyInjection;
namespace commercetools.Api.Serialization
{
    public static class DependencyInjectionSetup
    {
        public static void UseSerialization(this IServiceCollection services)
        {
            services.AddSingleton<ISerializerService, SerializerService>();
        }
    }
}
