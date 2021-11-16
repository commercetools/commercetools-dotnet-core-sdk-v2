using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetDeliveryItemsAction : IOrderSetDeliveryItemsAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public List<IDeliveryItem> Items { get; set; }
        public OrderSetDeliveryItemsAction()
        {
            this.Action = "setDeliveryItems";
        }
    }
}
