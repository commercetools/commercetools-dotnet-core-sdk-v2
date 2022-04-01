using commercetools.Sdk.Api.Models.Zones;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddZoneAction))]
    public partial interface IShippingMethodAddZoneAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }
    }
}
