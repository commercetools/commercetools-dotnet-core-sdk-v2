using commercetools.Api.Models.Channels;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Channels
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ChannelAddRolesAction), "addRoles")]
    [JsonSubtypes.KnownSubType(typeof(ChannelChangeDescriptionAction), "changeDescription")]
    [JsonSubtypes.KnownSubType(typeof(ChannelChangeKeyAction), "changeKey")]
    [JsonSubtypes.KnownSubType(typeof(ChannelChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ChannelRemoveRolesAction), "removeRoles")]
    [JsonSubtypes.KnownSubType(typeof(ChannelSetAddressAction), "setAddress")]
    [JsonSubtypes.KnownSubType(typeof(ChannelSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ChannelSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ChannelSetGeoLocationAction), "setGeoLocation")]
    [JsonSubtypes.KnownSubType(typeof(ChannelSetRolesAction), "setRoles")]
    public abstract class ChannelUpdateAction 
    {
        public string Action { get; set;}
    }
}
