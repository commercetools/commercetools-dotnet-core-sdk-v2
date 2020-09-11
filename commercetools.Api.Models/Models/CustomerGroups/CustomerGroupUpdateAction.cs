using commercetools.Api.Models.CustomerGroups;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomerGroups
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CustomerGroupSetKeyAction), "setKey")]
    public abstract class CustomerGroupUpdateAction 
    {
        public string Action { get; set;}
    }
}
