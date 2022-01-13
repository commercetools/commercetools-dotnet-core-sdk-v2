using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetParcelItemsAction : IOrderSetParcelItemsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public List<IDeliveryItem> Items { get; set; }
        public OrderSetParcelItemsAction()
        {
            this.Action = "setParcelItems";
        }
    }
}
