using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartValueTier))]
    public partial interface ICartValueTier : IShippingRatePriceTier
    {
        long MinimumCentAmount { get; set; }

        IMoney Price { get; set; }

        bool? IsMatching { get; set; }

    }
}
