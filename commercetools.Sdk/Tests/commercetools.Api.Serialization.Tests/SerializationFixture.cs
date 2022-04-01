using commercetools.Base.Serialization;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.Api.Serialization.Tests
{
    public class SerializationFixture
    {
        public SerializationFixture()
        {
            var services = new ServiceCollection();
            services.UseCommercetoolsApiSerialization();
            var serviceProvider = services.BuildServiceProvider();
            this.SerializerService = serviceProvider.GetService<SerializerService>();
        }

        public ISerializerService SerializerService { get; private set; }
    }
}