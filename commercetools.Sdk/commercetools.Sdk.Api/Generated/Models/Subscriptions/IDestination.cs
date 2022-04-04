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
    public partial interface IDestination
    {
        string Type { get; set; }
    }
}
