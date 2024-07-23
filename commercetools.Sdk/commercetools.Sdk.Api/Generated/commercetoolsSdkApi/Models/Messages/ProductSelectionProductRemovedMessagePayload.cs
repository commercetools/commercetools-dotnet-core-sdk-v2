using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionProductRemovedMessagePayload : IProductSelectionProductRemovedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public ProductSelectionProductRemovedMessagePayload()
        {
            this.Type = "ProductSelectionProductRemoved";
        }
    }
}
