using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Events.Event))]
    [SubTypeDiscriminator("CheckoutOrderCreationFailed", typeof(commercetools.Sdk.Api.Models.Events.CheckoutOrderCreationFailedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentAuthorizationCancelled", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationCancelledEvent))]
    [SubTypeDiscriminator("CheckoutPaymentAuthorizationFailed", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationFailedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentAuthorized", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentCancelAuthorizationFailed", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentCancelAuthorizationFailedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentCharged", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentChargeFailed", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargeFailedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentRefunded", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundedEvent))]
    [SubTypeDiscriminator("CheckoutPaymentRefundFailed", typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundFailedEvent))]
    [SubTypeDiscriminator("ImportContainerCreated", typeof(commercetools.Sdk.Api.Models.Events.ImportContainerCreatedEvent))]
    [SubTypeDiscriminator("ImportContainerDeleted", typeof(commercetools.Sdk.Api.Models.Events.ImportContainerDeletedEvent))]
    [SubTypeDiscriminator("ImportOperationRejected", typeof(commercetools.Sdk.Api.Models.Events.ImportOperationRejectedEvent))]
    [SubTypeDiscriminator("ImportUnresolved", typeof(commercetools.Sdk.Api.Models.Events.ImportUnresolvedEvent))]
    [SubTypeDiscriminator("ImportValidationFailed", typeof(commercetools.Sdk.Api.Models.Events.ImportValidationFailedEvent))]
    [SubTypeDiscriminator("ImportWaitForMasterVariant", typeof(commercetools.Sdk.Api.Models.Events.ImportWaitForMasterVariantEvent))]
    public partial interface IEvent
    {
        string Id { get; set; }

        string NotificationType { get; set; }

        IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IEventType Type { get; set; }

        DateTime CreatedAt { get; set; }

        static commercetools.Sdk.Api.Models.Events.CheckoutOrderCreationFailedEvent CheckoutOrderCreationFailed(Action<commercetools.Sdk.Api.Models.Events.CheckoutOrderCreationFailedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutOrderCreationFailedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationCancelledEvent CheckoutPaymentAuthorizationCancelled(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationCancelledEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationCancelledEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationFailedEvent CheckoutPaymentAuthorizationFailed(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationFailedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationFailedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizedEvent CheckoutPaymentAuthorized(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentCancelAuthorizationFailedEvent CheckoutPaymentCancelAuthorizationFailed(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentCancelAuthorizationFailedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentCancelAuthorizationFailedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargedEvent CheckoutPaymentCharged(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargeFailedEvent CheckoutPaymentChargeFailed(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargeFailedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentChargeFailedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundedEvent CheckoutPaymentRefunded(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundFailedEvent CheckoutPaymentRefundFailed(Action<commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundFailedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.CheckoutPaymentRefundFailedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.ImportContainerCreatedEvent ImportContainerCreated(Action<commercetools.Sdk.Api.Models.Events.ImportContainerCreatedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.ImportContainerCreatedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.ImportContainerDeletedEvent ImportContainerDeleted(Action<commercetools.Sdk.Api.Models.Events.ImportContainerDeletedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.ImportContainerDeletedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.ImportOperationRejectedEvent ImportOperationRejected(Action<commercetools.Sdk.Api.Models.Events.ImportOperationRejectedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.ImportOperationRejectedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.ImportUnresolvedEvent ImportUnresolved(Action<commercetools.Sdk.Api.Models.Events.ImportUnresolvedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.ImportUnresolvedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.ImportValidationFailedEvent ImportValidationFailed(Action<commercetools.Sdk.Api.Models.Events.ImportValidationFailedEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.ImportValidationFailedEvent();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Events.ImportWaitForMasterVariantEvent ImportWaitForMasterVariant(Action<commercetools.Sdk.Api.Models.Events.ImportWaitForMasterVariantEvent> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Events.ImportWaitForMasterVariantEvent();
            init?.Invoke(t);
            return t;
        }
    }
}
