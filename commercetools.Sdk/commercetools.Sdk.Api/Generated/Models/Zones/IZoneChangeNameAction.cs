using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneChangeNameAction))]
    public partial interface IZoneChangeNameAction : IZoneUpdateAction
    {
        string Name { get; set; }

    }
}
