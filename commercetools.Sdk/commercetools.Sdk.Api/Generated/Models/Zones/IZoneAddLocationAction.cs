using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneAddLocationAction))]
    public partial interface IZoneAddLocationAction : IZoneUpdateAction
    {
        ILocation Location { get; set; }

    }
}
