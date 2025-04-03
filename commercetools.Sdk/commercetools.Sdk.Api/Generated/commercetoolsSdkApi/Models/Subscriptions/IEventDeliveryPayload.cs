using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.EventDeliveryPayload))]
    public partial interface IEventDeliveryPayload : ISubscriptionNotification
    {
        string Id { get; set; }

        IEventType Type { get; set; }

        string ResourceType { get; set; }

        Object Data { get; set; }

        DateTime CreatedAt { get; set; }

    }
}
