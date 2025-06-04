using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizationCancelledEvent))]
    public partial interface ICheckoutPaymentAuthorizationCancelledEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        ICheckoutMessagePaymentsPayloadBaseData Data { get; set; }

    }
}
