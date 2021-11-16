using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Subscriptions.Destination))]
    [SubTypeDiscriminator("AzureServiceBus", typeof(commercetools.Api.Models.Subscriptions.AzureServiceBusDestination))]
    [SubTypeDiscriminator("EventGrid", typeof(commercetools.Api.Models.Subscriptions.AzureEventGridDestination))]
    [SubTypeDiscriminator("GoogleCloudPubSub", typeof(commercetools.Api.Models.Subscriptions.GoogleCloudPubSubDestination))]
    [SubTypeDiscriminator("IronMQ", typeof(commercetools.Api.Models.Subscriptions.IronMqDestination))]
    [SubTypeDiscriminator("SNS", typeof(commercetools.Api.Models.Subscriptions.SnsDestination))]
    [SubTypeDiscriminator("SQS", typeof(commercetools.Api.Models.Subscriptions.SqsDestination))]
    public partial interface IDestination
    {
        string Type { get; set; }
    }
}
