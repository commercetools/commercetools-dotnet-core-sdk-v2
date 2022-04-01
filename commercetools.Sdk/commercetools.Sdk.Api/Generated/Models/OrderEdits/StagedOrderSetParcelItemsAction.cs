using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
