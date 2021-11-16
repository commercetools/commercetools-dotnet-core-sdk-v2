using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryItemsAction : IStagedOrderSetDeliveryItemsAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public List<IDeliveryItem> Items { get; set; }
        public StagedOrderSetDeliveryItemsAction()
        {
            this.Action = "setDeliveryItems";
        }
    }
}
