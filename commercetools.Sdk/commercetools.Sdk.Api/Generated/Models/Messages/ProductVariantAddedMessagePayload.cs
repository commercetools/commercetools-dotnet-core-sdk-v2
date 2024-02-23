using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductVariantAddedMessagePayload : IProductVariantAddedMessagePayload
    {
        public string Type { get; set; }

        public IProductVariant Variant { get; set; }

        public bool Staged { get; set; }
        public ProductVariantAddedMessagePayload()
        {
            this.Type = "ProductVariantAdded";
        }
    }
}
