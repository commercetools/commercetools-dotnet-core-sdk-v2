using commercetools.Sdk.Api.Models.Subscriptions;
using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class CheckoutPaymentCancelAuthorizationFailedEvent : ICheckoutPaymentCancelAuthorizationFailedEvent
    {
        public string Id { get; set; }

        public string NotificationType { get; set; }

        public IEventSubscriptionResourceTypeId ResourceType { get; set; }

        public IEventType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICheckoutMessagePaymentsPayloadBaseData Data { get; set; }
        public CheckoutPaymentCancelAuthorizationFailedEvent()
        {
            this.Type = IEventType.FindEnum("CheckoutPaymentCancelAuthorizationFailed");
        }
    }
}
