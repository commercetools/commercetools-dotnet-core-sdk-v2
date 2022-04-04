using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    public partial class CartValueTier : ICartValueTier
    {
        public IShippingRateTierType Type { get; set; }

        public long MinimumCentAmount { get; set; }

        public IMoney Price { get; set; }

        public bool? IsMatching { get; set; }
        public CartValueTier()
        {
            this.Type = IShippingRateTierType.FindEnum("CartValue");
        }
    }
}
