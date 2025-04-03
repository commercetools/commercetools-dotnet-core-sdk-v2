using System;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class EventDeliveryPayload : IEventDeliveryPayload
    {
        public string NotificationType { get; set; }

        public string Id { get; set; }

        public IEventType Type { get; set; }

        public string ResourceType { get; set; }

        public Object Data { get; set; }

        public DateTime CreatedAt { get; set; }
        public EventDeliveryPayload()
        {
            this.NotificationType = "Event";
        }
    }
}
