using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(NotificationType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionNotification))]
    [SubTypeDiscriminator("Event", typeof(commercetools.Sdk.Api.Models.Subscriptions.EventDeliveryPayload))]
    [SubTypeDiscriminator("Message", typeof(commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload))]
    [SubTypeDiscriminator("ResourceCreated", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload))]
    [SubTypeDiscriminator("ResourceDeleted", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload))]
    [SubTypeDiscriminator("ResourceUpdated", typeof(commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload))]
    public partial interface ISubscriptionNotification
    {
        string NotificationType { get; set; }

        static commercetools.Sdk.Api.Models.Subscriptions.EventDeliveryPayload Event(Action<commercetools.Sdk.Api.Models.Subscriptions.EventDeliveryPayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.EventDeliveryPayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload Message(Action<commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.MessageDeliveryPayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload ResourceCreated(Action<commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.ResourceCreatedDeliveryPayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload ResourceDeleted(Action<commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.ResourceDeletedDeliveryPayload();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload ResourceUpdated(Action<commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Subscriptions.ResourceUpdatedDeliveryPayload();
            init?.Invoke(t);
            return t;
        }
    }
}
