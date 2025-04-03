using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Events.Event))]
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
