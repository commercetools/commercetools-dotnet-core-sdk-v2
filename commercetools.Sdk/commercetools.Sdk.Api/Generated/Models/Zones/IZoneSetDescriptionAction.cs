using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneSetDescriptionAction))]
    public partial interface IZoneSetDescriptionAction : IZoneUpdateAction
    {
        string Description { get; set;}
    }
}
