using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Subscriptions.DeliveryFormat))]
    [SubTypeDiscriminator("CloudEvents", typeof(commercetools.Api.Models.Subscriptions.DeliveryCloudEventsFormat))]
    [SubTypeDiscriminator("Platform", typeof(commercetools.Api.Models.Subscriptions.DeliveryPlatformFormat))]
    public partial interface IDeliveryFormat
    {
        string Type { get; set; }
    }
}
