using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(NotificationType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Subscriptions.DeliveryPayload))]
    [SubTypeDiscriminator("Message", typeof(commercetools.Api.Models.Subscriptions.MessageDeliveryPayload))]
    [SubTypeDiscriminator("ResourceCreated", typeof(commercetools.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload))]
    [SubTypeDiscriminator("ResourceDeleted", typeof(commercetools.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload))]
    [SubTypeDiscriminator("ResourceUpdated", typeof(commercetools.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload))]
    public partial interface IDeliveryPayload
    {
        string ProjectKey { get; set; }

        string NotificationType { get; set; }

        IReference Resource { get; set; }

        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }
    }
}
