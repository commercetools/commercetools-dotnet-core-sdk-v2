

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceCustomFieldsRemovedMessagePayload : IProductPriceCustomFieldsRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PriceId { get; set; }

        public long VariantId { get; set; }

        public bool Staged { get; set; }
        public ProductPriceCustomFieldsRemovedMessagePayload()
        {
            this.Type = "ProductPriceCustomFieldsRemoved";
        }
    }
}
