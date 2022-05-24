using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Zones.ZoneUpdateAction))]
    [SubTypeDiscriminator("addLocation", typeof(commercetools.Sdk.Api.Models.Zones.ZoneAddLocationAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Zones.ZoneChangeNameAction))]
    [SubTypeDiscriminator("removeLocation", typeof(commercetools.Sdk.Api.Models.Zones.ZoneRemoveLocationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Zones.ZoneSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Zones.ZoneSetKeyAction))]
    public partial interface IZoneUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IZoneUpdateAction>
    {
        new string Action { get; set; }
    }
}
