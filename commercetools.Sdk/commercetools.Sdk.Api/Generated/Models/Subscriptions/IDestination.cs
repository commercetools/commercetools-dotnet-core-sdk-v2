using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.Destination))]
    [SubTypeDiscriminator("AzureServiceBus", typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination))]
    [SubTypeDiscriminator("EventBridge", typeof(commercetools.Sdk.Api.Models.Subscriptions.EventBridgeDestination))]
    [SubTypeDiscriminator("EventGrid", typeof(commercetools.Sdk.Api.Models.Subscriptions.AzureEventGridDestination))]
    [SubTypeDiscriminator("GoogleCloudPubSub", typeof(commercetools.Sdk.Api.Models.Subscriptions.GoogleCloudPubSubDestination))]
    [SubTypeDiscriminator("IronMQ", typeof(commercetools.Sdk.Api.Models.Subscriptions.IronMqDestination))]
    [SubTypeDiscriminator("SNS", typeof(commercetools.Sdk.Api.Models.Subscriptions.SnsDestination))]
    [SubTypeDiscriminator("SQS", typeof(commercetools.Sdk.Api.Models.Subscriptions.SqsDestination))]
    [Obsolete]
    public partial interface IDestination
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination AzureServiceBus(Action<commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.AzureServiceBusDestination();
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

        [Obsolete]
        static commercetools.Sdk.Api.Models.Subscriptions.IronMqDestination IronMq(Action<commercetools.Sdk.Api.Models.Subscriptions.IronMqDestination> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.IronMqDestination();
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
