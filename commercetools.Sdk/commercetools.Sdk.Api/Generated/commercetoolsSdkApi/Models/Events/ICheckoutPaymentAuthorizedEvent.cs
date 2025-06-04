using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.CheckoutPaymentAuthorizedEvent))]
    public partial interface ICheckoutPaymentAuthorizedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        ICheckoutMessagePaymentsPayloadBaseData Data { get; set; }

    }
}
