using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDeliveryItemsAction : IStagedOrderSetDeliveryItemsAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }
        public StagedOrderSetDeliveryItemsAction()
        {
            this.Action = "setDeliveryItems";
        }
    }
}
