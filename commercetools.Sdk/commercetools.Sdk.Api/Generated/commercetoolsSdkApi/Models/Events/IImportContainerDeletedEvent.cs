using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportContainerDeletedEvent))]
    public partial interface IImportContainerDeletedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IImportContainerDeletedEventData Data { get; set; }

    }
}
