using commercetools.Api.Models.Subscriptions;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Subscriptions
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(GoogleCloudPubSubDestination), "GoogleCloudPubSub")]
    [JsonSubtypes.KnownSubType(typeof(IronMqDestination), "IronMQ")]
    [JsonSubtypes.KnownSubType(typeof(SnsDestination), "SNS")]
    [JsonSubtypes.KnownSubType(typeof(SqsDestination), "SQS")]
    [JsonSubtypes.KnownSubType(typeof(AzureEventGridDestination), "EventGrid")]
    [JsonSubtypes.KnownSubType(typeof(AzureServiceBusDestination), "AzureServiceBus")]
    public abstract class Destination 
    {
        public string Type { get; set;}
    }
}
