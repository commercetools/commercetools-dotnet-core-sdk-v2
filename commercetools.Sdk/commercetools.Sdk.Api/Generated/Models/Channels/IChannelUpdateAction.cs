using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addRoles", typeof(commercetools.Api.Models.Channels.ChannelAddRolesAction))]
    [SubTypeDiscriminator("changeDescription", typeof(commercetools.Api.Models.Channels.ChannelChangeDescriptionAction))]
    [SubTypeDiscriminator("changeKey", typeof(commercetools.Api.Models.Channels.ChannelChangeKeyAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Channels.ChannelChangeNameAction))]
    [SubTypeDiscriminator("removeRoles", typeof(commercetools.Api.Models.Channels.ChannelRemoveRolesAction))]
    [SubTypeDiscriminator("setAddress", typeof(commercetools.Api.Models.Channels.ChannelSetAddressAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Channels.ChannelSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Channels.ChannelSetCustomTypeAction))]
    [SubTypeDiscriminator("setGeoLocation", typeof(commercetools.Api.Models.Channels.ChannelSetGeoLocationAction))]
    [SubTypeDiscriminator("setRoles", typeof(commercetools.Api.Models.Channels.ChannelSetRolesAction))]
    public interface IChannelUpdateAction 
    {
        string Action { get; set;}
    }
}
