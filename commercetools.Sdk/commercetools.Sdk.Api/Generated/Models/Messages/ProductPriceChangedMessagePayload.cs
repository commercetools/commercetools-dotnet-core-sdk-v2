using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceChangedMessagePayload : IProductPriceChangedMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public IPrice OldPrice { get; set; }

        public IPrice NewPrice { get; set; }

        public bool Staged { get; set; }

        public IPrice OldStagedPrice { get; set; }
        public ProductPriceChangedMessagePayload()
        {
            this.Type = "ProductPriceChanged";
        }
    }
}
