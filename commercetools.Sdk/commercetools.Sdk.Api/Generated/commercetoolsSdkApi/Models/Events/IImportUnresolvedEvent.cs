using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportUnresolvedEvent))]
    public partial interface IImportUnresolvedEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IImportUnresolvedEventData Data { get; set; }

    }
}
