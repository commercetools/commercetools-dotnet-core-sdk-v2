using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneSetDescriptionAction))]
    public partial interface IZoneSetDescriptionAction : IZoneUpdateAction
    {
        string Description { get; set; }

    }
}
