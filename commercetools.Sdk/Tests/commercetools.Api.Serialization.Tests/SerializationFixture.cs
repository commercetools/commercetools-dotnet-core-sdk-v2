using commercetools.Base.Serialization;
using commercetools.Sdk.Api;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.Serialization.Tests
{
    public class SerializationFixture
    {
        public SerializationFixture()
        {
            var services = new ServiceCollection();
            services.UseCommercetoolsApiSerialization();
            var serviceProvider = services.BuildServiceProvider();
            this.SerializerService = serviceProvider.GetService<ISerializerService>();
        }

        public ISerializerService SerializerService { get; private set; }
    }
}