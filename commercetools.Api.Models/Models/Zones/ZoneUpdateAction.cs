using commercetools.Api.Models.Zones;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Zones
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ZoneAddLocationAction), "addLocation")]
    [JsonSubtypes.KnownSubType(typeof(ZoneChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ZoneRemoveLocationAction), "removeLocation")]
    [JsonSubtypes.KnownSubType(typeof(ZoneSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(ZoneSetKeyAction), "setKey")]
    public abstract class ZoneUpdateAction 
    {
        public string Action { get; set;}
    }
}
