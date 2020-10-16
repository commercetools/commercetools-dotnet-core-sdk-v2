using commercetools.Base.Registration;
using commercetools.Base.Serialization.Mappers;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Base.Serialization
{
    public static class DependencyInjectionSetup
    {
        public static void UseSerialization(this IServiceCollection services)
        {
            services.RegisterAllTypes(typeof(ICustomJsonMapper<>), ServiceLifetime.Singleton);
            services.RegisterAllTypes(typeof(IMapperTypeRetriever<>), ServiceLifetime.Singleton);
            // services.AddSingleton<ISerializerService, BaseSerializerService>();
        }
    }
}
