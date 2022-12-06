using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryItemsUpdatedMessagePayload : IDeliveryItemsUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IList<IDeliveryItem> OldItems { get; set; }
        public IEnumerable<IDeliveryItem> OldItemsEnumerable { set => OldItems = value.ToList(); }


        public string ShippingKey { get; set; }
        public DeliveryItemsUpdatedMessagePayload()
        {
            this.Type = "DeliveryItemsUpdated";
        }
    }
}
