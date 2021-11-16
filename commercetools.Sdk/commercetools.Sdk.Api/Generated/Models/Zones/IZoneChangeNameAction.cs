using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneChangeNameAction))]
    public partial interface IZoneChangeNameAction : IZoneUpdateAction
    {
        string Name { get; set;}
    }
}
