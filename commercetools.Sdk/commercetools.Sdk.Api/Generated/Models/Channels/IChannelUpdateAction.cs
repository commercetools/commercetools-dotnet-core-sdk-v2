using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Channels.ChannelUpdateAction))]
    [SubTypeDiscriminator("addRoles", typeof(commercetools.Api.Models.Channels.ChannelAddRolesAction))]
    [SubTypeDiscriminator("changeDescription", typeof(commercetools.Api.Models.Channels.ChannelChangeDescriptionAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Api.Models.Channels.ChannelChangeKeyAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Channels.ChannelChangeNameAction))]
    [SubTypeDiscriminator("removeRoles", typeof(commercetools.Api.Models.Channels.ChannelRemoveRolesAction))]
    [SubTypeDiscriminator("setAddress", typeof(commercetools.Api.Models.Channels.ChannelSetAddressAction))]
    [SubTypeDiscriminator("setAddressCustomField", typeof(commercetools.Api.Models.Channels.ChannelSetAddressCustomFieldAction))]
    [SubTypeDiscriminator("setAddressCustomType", typeof(commercetools.Api.Models.Channels.ChannelSetAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Channels.ChannelSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Channels.ChannelSetCustomTypeAction))]
    [SubTypeDiscriminator("setGeoLocation", typeof(commercetools.Api.Models.Channels.ChannelSetGeoLocationAction))]
    [SubTypeDiscriminator("setRoles", typeof(commercetools.Api.Models.Channels.ChannelSetRolesAction))]
    public partial interface IChannelUpdateAction
    {
        string Action { get; set; }
    }
}
