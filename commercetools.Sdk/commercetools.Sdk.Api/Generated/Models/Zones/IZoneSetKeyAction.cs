using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneSetKeyAction))]
    public partial interface IZoneSetKeyAction : IZoneUpdateAction
    {
        string Key { get; set;}
    }
}
