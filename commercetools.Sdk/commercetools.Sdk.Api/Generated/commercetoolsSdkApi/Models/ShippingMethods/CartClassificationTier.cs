using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class CartClassificationTier : ICartClassificationTier
    {
        public IShippingRateTierType Type { get; set; }

        public string Value { get; set; }

        public IMoney Price { get; set; }

        public bool? IsMatching { get; set; }
        public CartClassificationTier()
        {
            this.Type = IShippingRateTierType.FindEnum("CartClassification");
        }
    }
}
