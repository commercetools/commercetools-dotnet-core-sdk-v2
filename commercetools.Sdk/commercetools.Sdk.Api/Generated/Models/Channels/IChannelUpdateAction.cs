using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Channels.ChannelUpdateAction))]
    [SubTypeDiscriminator("addRoles", typeof(commercetools.Sdk.Api.Models.Channels.ChannelAddRolesAction))]
    [SubTypeDiscriminator("changeDescription", typeof(commercetools.Sdk.Api.Models.Channels.ChannelChangeDescriptionAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Sdk.Api.Models.Channels.ChannelChangeKeyAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Channels.ChannelChangeNameAction))]
    [SubTypeDiscriminator("removeRoles", typeof(commercetools.Sdk.Api.Models.Channels.ChannelRemoveRolesAction))]
    [SubTypeDiscriminator("setAddress", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetAddressAction))]
    [SubTypeDiscriminator("setAddressCustomField", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomFieldAction))]
    [SubTypeDiscriminator("setAddressCustomType", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetCustomTypeAction))]
    [SubTypeDiscriminator("setGeoLocation", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetGeoLocationAction))]
    [SubTypeDiscriminator("setRoles", typeof(commercetools.Sdk.Api.Models.Channels.ChannelSetRolesAction))]
    public partial interface IChannelUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IChannelUpdateAction>
    {
        new string Action { get; set; }
    }
}
