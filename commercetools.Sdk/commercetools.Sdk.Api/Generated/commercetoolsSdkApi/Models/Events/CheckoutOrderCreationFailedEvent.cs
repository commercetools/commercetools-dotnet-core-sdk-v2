using commercetools.Sdk.Api.Models.Subscriptions;
using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class CheckoutOrderCreationFailedEvent : ICheckoutOrderCreationFailedEvent
    {
        public string Id { get; set; }

        public string NotificationType { get; set; }

        public IEventSubscriptionResourceTypeId ResourceType { get; set; }

        public IEventType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICheckoutMessageOrderPayloadBaseData Data { get; set; }
        public CheckoutOrderCreationFailedEvent()
        {
            this.Type = IEventType.FindEnum("CheckoutOrderCreationFailed");
        }
    }
}
