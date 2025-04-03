using commercetools.Sdk.Api.Models.Subscriptions;
using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class ImportValidationFailedEvent : IImportValidationFailedEvent
    {
        public string Id { get; set; }

        public string NotificationType { get; set; }

        public IEventSubscriptionResourceTypeId ResourceType { get; set; }

        public IEventType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public IImportValidationFailedEventData Data { get; set; }
        public ImportValidationFailedEvent()
        {
            this.Type = IEventType.FindEnum("ImportValidationFailed");
        }
    }
}
