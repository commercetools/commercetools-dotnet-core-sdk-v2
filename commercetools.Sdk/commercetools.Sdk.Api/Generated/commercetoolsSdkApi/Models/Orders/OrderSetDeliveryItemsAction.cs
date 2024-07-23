using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetDeliveryItemsAction : IOrderSetDeliveryItemsAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public OrderSetDeliveryItemsAction()
        {
            this.Action = "setDeliveryItems";
        }
    }
}
