using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class DeliveryItemsUpdatedMessagePayload : IDeliveryItemsUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public List<IDeliveryItem> OldItems { get; set; }
        public DeliveryItemsUpdatedMessagePayload()
        {
            this.Type = "DeliveryItemsUpdated";
        }
    }
}
