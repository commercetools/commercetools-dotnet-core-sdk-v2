using commercetools.Api.Registration;
using commercetools.Api.Serialization.Mappers;
using commercetools.Api.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;
namespace commercetools.Api.Serialization
{
    public static class DependencyInjectionSetup
    {
        public static void UseSerialization(this IServiceCollection services)
        {
            services.RegisterAllTypes(typeof(ICustomJsonMapper<>), ServiceLifetime.Singleton);
            services.RegisterAllTypes(typeof(IMapperTypeRetriever<>), ServiceLifetime.Singleton);
            services.AddSingleton<ISerializerService, SerializerService>();
        }
    }
}
