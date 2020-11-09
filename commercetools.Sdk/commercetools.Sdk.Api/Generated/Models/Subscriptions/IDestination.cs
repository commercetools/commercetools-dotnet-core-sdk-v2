using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("GoogleCloudPubSub", typeof(commercetools.Api.Models.Subscriptions.GoogleCloudPubSubDestination))]
    [SubTypeDiscriminator("IronMQ", typeof(commercetools.Api.Models.Subscriptions.IronMqDestination))]
    [SubTypeDiscriminator("SNS", typeof(commercetools.Api.Models.Subscriptions.SnsDestination))]
    [SubTypeDiscriminator("SQS", typeof(commercetools.Api.Models.Subscriptions.SqsDestination))]
    [SubTypeDiscriminator("AzureServiceBus", typeof(commercetools.Api.Models.Subscriptions.AzureServiceBusDestination))]
    [SubTypeDiscriminator("EventGrid", typeof(commercetools.Api.Models.Subscriptions.AzureEventGridDestination))]
    public partial interface IDestination 
    {
        string Type { get; set;}
    }
}
