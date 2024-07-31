using commercetools.Sdk.Api.Models.Zones;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction))]
    public partial interface IShippingMethodRemoveZoneAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set; }

    }
}
