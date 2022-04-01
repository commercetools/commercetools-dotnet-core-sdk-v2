using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Serialization;
using commercetools.Sdk.ImportApi;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Sdk.Api.Serialization.Tests
{
    public class ImportApiSerializationFixture
    {
        public ImportApiSerializationFixture()
        {
            var services = new ServiceCollection();
            services.UseCommercetoolsImportApiSerialization();
            var serviceProvider = services.BuildServiceProvider();
            this.SerializerService = serviceProvider.GetService<SerializerService>();
        }

        public ISerializerService SerializerService { get; private set; }
    }
}