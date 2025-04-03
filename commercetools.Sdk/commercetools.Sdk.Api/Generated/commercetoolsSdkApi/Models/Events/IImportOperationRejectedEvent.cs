using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportOperationRejectedEvent))]
    public partial interface IImportOperationRejectedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IImportOperationRejectedEventData Data { get; set; }

    }
}
