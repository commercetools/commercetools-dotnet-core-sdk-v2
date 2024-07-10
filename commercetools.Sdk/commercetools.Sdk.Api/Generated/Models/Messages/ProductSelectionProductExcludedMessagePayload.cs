using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionProductExcludedMessagePayload : IProductSelectionProductExcludedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantExclusion VariantExclusion { get; set; }
        public ProductSelectionProductExcludedMessagePayload()
        {
            this.Type = "ProductSelectionProductExcluded";
        }
    }
}
