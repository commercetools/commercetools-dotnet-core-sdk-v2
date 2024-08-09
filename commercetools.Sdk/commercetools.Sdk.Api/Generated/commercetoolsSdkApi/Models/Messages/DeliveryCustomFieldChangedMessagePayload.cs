using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryCustomFieldChangedMessagePayload : IDeliveryCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object PreviousValue { get; set; }

        public string DeliveryId { get; set; }
        public DeliveryCustomFieldChangedMessagePayload()
        {
            this.Type = "DeliveryCustomFieldChanged";
        }
    }
}
