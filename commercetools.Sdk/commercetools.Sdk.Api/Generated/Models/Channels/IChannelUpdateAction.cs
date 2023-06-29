using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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
    public partial interface IChannelUpdateAction
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.Channels.ChannelAddRolesAction AddRoles(Action<commercetools.Sdk.Api.Models.Channels.ChannelAddRolesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelAddRolesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelChangeDescriptionAction ChangeDescription(Action<commercetools.Sdk.Api.Models.Channels.ChannelChangeDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelChangeDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelChangeKeyAction ChangeKey(Action<commercetools.Sdk.Api.Models.Channels.ChannelChangeKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelChangeKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Channels.ChannelChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelRemoveRolesAction RemoveRoles(Action<commercetools.Sdk.Api.Models.Channels.ChannelRemoveRolesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelRemoveRolesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetAddressAction SetAddress(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetAddressAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetAddressAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomFieldAction SetAddressCustomField(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomTypeAction SetAddressCustomType(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetAddressCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetGeoLocationAction SetGeoLocation(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetGeoLocationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetGeoLocationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Channels.ChannelSetRolesAction SetRoles(Action<commercetools.Sdk.Api.Models.Channels.ChannelSetRolesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Channels.ChannelSetRolesAction();
            init?.Invoke(t);
            return t;
        }
    }
}
