using commercetools.Api.Models.Zones;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodAddZoneAction))]
    public partial interface IShippingMethodAddZoneAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set;}
    }
}
