using commercetools.Api.Models.Zones;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction))]
    public partial interface IShippingMethodRemoveZoneAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }
    }
}
