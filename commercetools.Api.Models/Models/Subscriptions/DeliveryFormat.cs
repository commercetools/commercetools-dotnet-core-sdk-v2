using commercetools.Api.Models.Subscriptions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(DeliveryPlatformFormat), "Platform")]
    [JsonSubtypes.KnownSubType(typeof(DeliveryCloudEventsFormat), "CloudEvents")]
    public abstract class DeliveryFormat 
    {
        public string Type { get; set;}
    }
}
