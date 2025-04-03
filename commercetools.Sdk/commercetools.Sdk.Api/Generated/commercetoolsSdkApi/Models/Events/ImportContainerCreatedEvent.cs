using commercetools.Sdk.Api.Models.Subscriptions;
using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class ImportContainerCreatedEvent : IImportContainerCreatedEvent
    {
        public string Id { get; set; }

        public string NotificationType { get; set; }

        public IEventSubscriptionResourceTypeId ResourceType { get; set; }

        public IEventType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public IImportContainerCreatedEventData Data { get; set; }
        public ImportContainerCreatedEvent()
        {
            this.Type = IEventType.FindEnum("ImportContainerCreated");
        }
    }
}
