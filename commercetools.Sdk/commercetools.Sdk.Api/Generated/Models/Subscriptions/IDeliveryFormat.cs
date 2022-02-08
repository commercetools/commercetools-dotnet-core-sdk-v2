using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Subscriptions.DeliveryFormat))]
    [SubTypeDiscriminator("CloudEvents", typeof(commercetools.Api.Models.Subscriptions.CloudEventsFormat))]
    [SubTypeDiscriminator("Platform", typeof(commercetools.Api.Models.Subscriptions.PlatformFormat))]
    public partial interface IDeliveryFormat
    {
        string Type { get; set; }
    }
}
