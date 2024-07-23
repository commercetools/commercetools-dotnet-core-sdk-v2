using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceCustomFieldsSetMessagePayload : IProductPriceCustomFieldsSetMessagePayload
    {
        public string Type { get; set; }

        public string PriceId { get; set; }

        public long VariantId { get; set; }

        public bool Staged { get; set; }

        public ICustomFields CustomField { get; set; }

        public string OldTypeId { get; set; }
        public ProductPriceCustomFieldsSetMessagePayload()
        {
            this.Type = "ProductPriceCustomFieldsSet";
        }
    }
}
