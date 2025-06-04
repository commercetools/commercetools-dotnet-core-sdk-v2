using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.CheckoutOrderCreationFailedEvent))]
    public partial interface ICheckoutOrderCreationFailedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        ICheckoutMessageOrderPayloadBaseData Data { get; set; }

    }
}
