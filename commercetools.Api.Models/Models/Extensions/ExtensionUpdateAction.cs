using commercetools.Api.Models.Extensions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionChangeDestinationAction), "changeDestination")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionChangeTriggersAction), "changeTriggers")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(ExtensionSetTimeoutInMsAction), "setTimeoutInMs")]
    public abstract class ExtensionUpdateAction 
    {
        public string Action { get; set;}
    }
}
