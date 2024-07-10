using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceAddedMessagePayload : IProductPriceAddedMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public IPrice Price { get; set; }

        public bool Staged { get; set; }
        public ProductPriceAddedMessagePayload()
        {
            this.Type = "ProductPriceAdded";
        }
    }
}
