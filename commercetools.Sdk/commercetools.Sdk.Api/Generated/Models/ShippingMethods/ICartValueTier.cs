using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.CartValueTier))]
    public partial interface ICartValueTier : IShippingRatePriceTier
    {
        long MinimumCentAmount { get; set; }

        IMoney Price { get; set; }

        bool? IsMatching { get; set; }
    }
}
