using commercetools.Sdk.Api.Models.Subscriptions;
using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class ImportContainerDeletedEvent : IImportContainerDeletedEvent
    {
        public string Id { get; set; }

        public string NotificationType { get; set; }

        public IEventSubscriptionResourceTypeId ResourceType { get; set; }

        public IEventType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public IImportContainerDeletedEventData Data { get; set; }
        public ImportContainerDeletedEvent()
        {
            this.Type = IEventType.FindEnum("ImportContainerDeleted");
        }
    }
}
