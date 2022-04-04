using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.DeliveryFormat))]
    [SubTypeDiscriminator("CloudEvents", typeof(commercetools.Sdk.Api.Models.Subscriptions.CloudEventsFormat))]
    [SubTypeDiscriminator("Platform", typeof(commercetools.Sdk.Api.Models.Subscriptions.PlatformFormat))]
    public partial interface IDeliveryFormat
    {
        string Type { get; set; }
    }
}
