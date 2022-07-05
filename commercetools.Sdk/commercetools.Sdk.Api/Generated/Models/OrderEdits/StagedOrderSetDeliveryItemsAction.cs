using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
