using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelItemsUpdatedMessagePayload : IParcelItemsUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string ParcelId { get; set; }

        public string DeliveryId { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public List<IDeliveryItem> OldItems { get; set; }
        public ParcelItemsUpdatedMessagePayload()
        {
            this.Type = "ParcelItemsUpdated";
        }
    }
}
