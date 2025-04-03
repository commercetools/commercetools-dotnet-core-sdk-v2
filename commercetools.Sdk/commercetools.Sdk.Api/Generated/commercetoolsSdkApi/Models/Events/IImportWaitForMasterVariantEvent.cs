using commercetools.Sdk.Api.Models.Subscriptions;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportWaitForMasterVariantEvent))]
    public partial interface IImportWaitForMasterVariantEvent : IEvent
    {
        new IEventSubscriptionResourceTypeId ResourceType { get; set; }

        IImportWaitForMasterVariantEventData Data { get; set; }

    }
}
