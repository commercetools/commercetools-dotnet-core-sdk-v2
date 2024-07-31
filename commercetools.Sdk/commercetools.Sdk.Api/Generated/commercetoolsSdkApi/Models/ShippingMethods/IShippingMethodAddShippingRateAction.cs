using commercetools.Sdk.Api.Models.Zones;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddShippingRateAction))]
    public partial interface IShippingMethodAddShippingRateAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

    }
}
