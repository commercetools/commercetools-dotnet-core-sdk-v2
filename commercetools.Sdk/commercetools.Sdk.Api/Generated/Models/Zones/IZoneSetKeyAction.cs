using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneSetKeyAction))]
    public partial interface IZoneSetKeyAction : IZoneUpdateAction
    {
        string Key { get; set; }

    }
}
