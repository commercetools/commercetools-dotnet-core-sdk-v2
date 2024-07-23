using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceRemovedMessagePayload : IProductPriceRemovedMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public IPrice Price { get; set; }

        public bool Staged { get; set; }
        public ProductPriceRemovedMessagePayload()
        {
            this.Type = "ProductPriceRemoved";
        }
    }
}
