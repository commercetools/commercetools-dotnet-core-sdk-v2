using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier))]
    public partial interface ICartScoreTier : IShippingRatePriceTier
    {
        double Score { get; set; }

        IMoney Price { get; set; }

        IPriceFunction PriceFunction { get; set; }

        bool? IsMatching { get; set; }
    }
}
