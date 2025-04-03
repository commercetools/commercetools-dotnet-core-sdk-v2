using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportValidationFailedEvent))]
    public partial interface IImportValidationFailedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IImportValidationFailedEventData Data { get; set; }

    }
}
