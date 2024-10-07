

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryCustomFieldRemovedMessagePayload : IDeliveryCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string DeliveryId { get; set; }
        public DeliveryCustomFieldRemovedMessagePayload()
        {
            this.Type = "DeliveryCustomFieldRemoved";
        }
    }
}
