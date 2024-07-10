using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.Destination))]
    [SubTypeDiscriminator("AzureServiceBus", typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination))]
    [SubTypeDiscriminator("ConfluentCloud", typeof(commercetools.Sdk.Api.Models.Subscriptions.ConfluentCloudDestination))]
    [SubTypeDiscriminator("EventBridge", typeof(commercetools.Sdk.Api.Models.Subscriptions.EventBridgeDestination))]
    [SubTypeDiscriminator("EventGrid", typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination))]
    [SubTypeDiscriminator("GoogleCloudPubSub", typeof(commercetools.Sdk.Api.Models.Subscriptions.GoogleCloudPubSubDestination))]
    [SubTypeDiscriminator("SNS", typeof(commercetools.Sdk.Api.Models.Subscriptions.SnsDestination))]
    [SubTypeDiscriminator("SQS", typeof(commercetools.Sdk.Api.Models.Subscriptions.SqsDestination))]
    public partial interface IDestination
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination AzureServiceBus(Action<commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.ConfluentCloudDestination ConfluentCloud(Action<commercetools.Sdk.Api.Models.Subscriptions.ConfluentCloudDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.ConfluentCloudDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.EventBridgeDestination EventBridge(Action<commercetools.Sdk.Api.Models.Subscriptions.EventBridgeDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.EventBridgeDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination EventGrid(Action<commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.GoogleCloudPubSubDestination GoogleCloudPubSub(Action<commercetools.Sdk.Api.Models.Subscriptions.GoogleCloudPubSubDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.GoogleCloudPubSubDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.SnsDestination Sns(Action<commercetools.Sdk.Api.Models.Subscriptions.SnsDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.SnsDestination();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.SqsDestination Sqs(Action<commercetools.Sdk.Api.Models.Subscriptions.SqsDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.SqsDestination();
            init?.Invoke(t);
            return t;
        }
    }
}
