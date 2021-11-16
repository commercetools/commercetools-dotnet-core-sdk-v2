using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneAddLocationAction))]
    public partial interface IZoneAddLocationAction : IZoneUpdateAction
    {
        ILocation Location { get; set;}
    }
}
