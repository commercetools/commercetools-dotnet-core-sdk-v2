using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryCustomFieldAddedMessagePayload : IDeliveryCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public string DeliveryId { get; set; }
        public DeliveryCustomFieldAddedMessagePayload()
        {
            this.Type = "DeliveryCustomFieldAdded";
        }
    }
}
