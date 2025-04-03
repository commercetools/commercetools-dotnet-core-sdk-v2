using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Subscriptions;

[TypeDiscriminator(nameof(NotificationType))]
[DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.DeliveryPayload))]
[SubTypeDiscriminator("Message", typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload))]
[SubTypeDiscriminator("ResourceCreated", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload))]
[SubTypeDiscriminator("ResourceDeleted", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload))]
[SubTypeDiscriminator("ResourceUpdated", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload))]
public partial interface IDeliveryPayload
{
    new string NotificationType { get; set; }

}