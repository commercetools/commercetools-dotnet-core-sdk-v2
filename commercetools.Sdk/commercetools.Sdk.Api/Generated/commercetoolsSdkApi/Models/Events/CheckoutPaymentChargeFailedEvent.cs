using commercetools.Sdk.Api.Models.Subscriptions;
using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class CheckoutPaymentChargeFailedEvent : ICheckoutPaymentChargeFailedEvent
    {
        public string Id { get; set; }

        public string NotificationType { get; set; }

        public IEventSubscriptionResourceTypeId ResourceType { get; set; }

        public IEventType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICheckoutMessagePaymentsPayloadBaseData Data { get; set; }
        public CheckoutPaymentChargeFailedEvent()
        {
            this.Type = IEventType.FindEnum("CheckoutPaymentChargeFailed");
        }
    }
}
