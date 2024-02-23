using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneRemoveLocationAction))]
    public partial interface IZoneRemoveLocationAction : IZoneUpdateAction
    {
        ILocation Location { get; set; }

    }
}
