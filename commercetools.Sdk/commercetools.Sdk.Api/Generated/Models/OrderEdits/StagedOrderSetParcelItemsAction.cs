using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelItemsAction : IStagedOrderSetParcelItemsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public List<IDeliveryItem> Items { get; set; }
        public StagedOrderSetParcelItemsAction()
        {
            this.Action = "setParcelItems";
        }
    }
}
