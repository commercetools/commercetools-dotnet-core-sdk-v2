using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.CartClassificationTier))]
    public partial interface ICartClassificationTier : IShippingRatePriceTier
    {
        string Value { get; set; }

        IMoney Price { get; set; }

        bool? IsMatching { get; set; }
    }
}
