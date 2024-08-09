

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryCustomTypeRemovedMessagePayload : IDeliveryCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PreviousTypeId { get; set; }

        public string DeliveryId { get; set; }
        public DeliveryCustomTypeRemovedMessagePayload()
        {
            this.Type = "DeliveryCustomTypeRemoved";
        }
    }
}
