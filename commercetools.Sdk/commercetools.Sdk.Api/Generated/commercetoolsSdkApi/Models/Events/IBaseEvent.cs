using commercetools.Sdk.Api.Models.Subscriptions;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.BaseEvent))]
    public partial interface IBaseEvent
    {
        string Id { get; set; }

        string NotificationType { get; set; }

        IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IEventType Type { get; set; }

        Object Data { get; set; }

        DateTime CreatedAt { get; set; }

    }
}
