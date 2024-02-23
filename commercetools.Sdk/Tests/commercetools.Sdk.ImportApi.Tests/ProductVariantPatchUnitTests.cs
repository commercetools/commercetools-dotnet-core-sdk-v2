using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using commercetools.Sdk.ImportApi.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.ImportApi.Tests
{
    public class ProductVariantPatchUnitTests
    {
        private readonly IImportSerializerService _serializer;

        public ProductVariantPatchUnitTests()
        {
            var services = new ServiceCollection();
            services.UseCommercetoolsImportApiSerialization();
            var serviceProvider = services.BuildServiceProvider();
            this._serializer = serviceProvider.GetService<IImportSerializerService>();
        }


        [Fact]
        public void VariantPatch()
        {
            var patch = new ProductVariantPatch()
            {
                Attributes = new Attributes()
                {
                    {
                        "Foo",
                        new LocalizableTextAttribute() { Value = new LocalizedString() { { "en", "Foo"}, { "de", "Foo"}}}
                    },
                    {
                        "Bar",
                        null
                    }
                },
                ProductVariant = new ProductVariantKeyReference { Key = "ProductId" },
                Staged = false
            };

            var jsonPatch = _serializer.Serialize(patch);

            Assert.Equal("{\"productVariant\":{\"key\":\"ProductId\",\"typeId\":\"product-variant\"},\"attributes\":{\"Foo\":{\"type\":\"ltext\",\"value\":{\"en\":\"Foo\",\"de\":\"Foo\"}},\"Bar\":null},\"staged\":false}", jsonPatch);
        }
    }
}