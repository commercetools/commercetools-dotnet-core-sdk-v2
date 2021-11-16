using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneRemoveLocationAction))]
    public partial interface IZoneRemoveLocationAction : IZoneUpdateAction
    {
        ILocation Location { get; set;}
    }
}
