using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(NotificationType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.DeliveryPayload))]
    [SubTypeDiscriminator("Message", typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload))]
    [SubTypeDiscriminator("ResourceCreated", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload))]
    [SubTypeDiscriminator("ResourceDeleted", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload))]
    [SubTypeDiscriminator("ResourceUpdated", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload))]
    public partial interface IDeliveryPayload
    {
        string ProjectKey { get; set; }

        string NotificationType { get; set; }

        IReference Resource { get; set; }

        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }
    }
}
