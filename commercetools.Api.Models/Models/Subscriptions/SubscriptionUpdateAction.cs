using commercetools.Api.Models.Subscriptions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(SubscriptionChangeDestinationAction), "changeDestination")]
    [JsonSubtypes.KnownSubType(typeof(SubscriptionSetChangesAction), "setChanges")]
    [JsonSubtypes.KnownSubType(typeof(SubscriptionSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(SubscriptionSetMessagesAction), "setMessages")]
    public abstract class SubscriptionUpdateAction 
    {
        public string Action { get; set;}
    }
}
