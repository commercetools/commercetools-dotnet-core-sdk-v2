using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.Api.Tests
{
    public class EnumTests
    {
        [Fact]
        public void Test_Serialize_Enum()
        {
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();

            var r = new ProductTypeReference();

            var p = s.BuildServiceProvider();
            //arrange
            var serializerService = p.GetService<SerializerService>();
            var t = serializerService.Serialize(r);

            Assert.Equal("{\"typeId\":\"product-type\"}", t);
        }
    }
}