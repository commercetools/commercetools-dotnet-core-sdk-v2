using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    public partial class CartScoreTier : ICartScoreTier
    {
        public IShippingRateTierType Type { get; set; }

        public double Score { get; set; }

        public IMoney Price { get; set; }

        public IPriceFunction PriceFunction { get; set; }

        public bool? IsMatching { get; set; }
        public CartScoreTier()
        {
            this.Type = IShippingRateTierType.FindEnum("CartScore");
        }
    }
}
