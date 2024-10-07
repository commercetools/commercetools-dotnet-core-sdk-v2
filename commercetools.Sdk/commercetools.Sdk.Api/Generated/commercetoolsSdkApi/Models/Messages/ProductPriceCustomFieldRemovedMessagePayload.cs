

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceCustomFieldRemovedMessagePayload : IProductPriceCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PriceId { get; set; }

        public long VariantId { get; set; }

        public bool Staged { get; set; }

        public string Name { get; set; }
        public ProductPriceCustomFieldRemovedMessagePayload()
        {
            this.Type = "ProductPriceCustomFieldRemoved";
        }
    }
}
