using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests
{
    public class EnumTests
    {
        [Fact]
        public void Test_Serialize_Enum()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsImportApiSerialization();

            var r = new ProductVariantImportRequest();

            var p = s.BuildServiceProvider();
            var serializerService = p.GetService<IImportSerializerService>();
            var t = serializerService.Serialize(r);

            Assert.Equal("{\"type\":\"product-variant\"}", t);
        }
    }
}