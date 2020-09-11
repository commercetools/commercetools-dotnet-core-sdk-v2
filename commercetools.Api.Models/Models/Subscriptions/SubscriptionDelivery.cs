using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Subscriptions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    [JsonConverter(typeof(JsonSubtypes), "notificationType")]
    [JsonSubtypes.KnownSubType(typeof(ResourceUpdatedDelivery), "ResourceUpdated")]
    [JsonSubtypes.KnownSubType(typeof(MessageDelivery), "Message")]
    [JsonSubtypes.KnownSubType(typeof(ResourceDeletedDelivery), "ResourceDeleted")]
    [JsonSubtypes.KnownSubType(typeof(ResourceCreatedDelivery), "ResourceCreated")]
    public abstract class SubscriptionDelivery 
    {
        public string ProjectKey { get; set;}
        
        public string NotificationType { get; set;}
        
        public Reference Resource { get; set;}
        
        public UserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
    }
}
