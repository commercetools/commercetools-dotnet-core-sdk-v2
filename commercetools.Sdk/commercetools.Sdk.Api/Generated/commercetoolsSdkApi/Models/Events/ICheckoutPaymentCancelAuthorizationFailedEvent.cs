using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentCancelAuthorizationFailedEvent))]
    public partial interface ICheckoutPaymentCancelAuthorizationFailedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        ICheckoutMessagePaymentsPayloadBaseData Data { get; set; }

    }
}
