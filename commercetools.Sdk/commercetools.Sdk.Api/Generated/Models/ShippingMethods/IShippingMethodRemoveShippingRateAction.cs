using commercetools.Api.Models.Zones;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction))]
    public partial interface IShippingMethodRemoveShippingRateAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }

        IShippingRateDraft ShippingRate { get; set; }
    }
}
