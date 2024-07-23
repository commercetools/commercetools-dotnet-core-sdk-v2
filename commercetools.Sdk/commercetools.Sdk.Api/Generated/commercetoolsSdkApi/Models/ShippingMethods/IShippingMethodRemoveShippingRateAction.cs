using commercetools.Sdk.Api.Models.Zones;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction))]
    public partial interface IShippingMethodRemoveShippingRateAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

    }
}
