using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionProductAddedMessagePayload : IProductSelectionProductAddedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantSelection VariantSelection { get; set; }
        public ProductSelectionProductAddedMessagePayload()
        {
            this.Type = "ProductSelectionProductAdded";
        }
    }
}
