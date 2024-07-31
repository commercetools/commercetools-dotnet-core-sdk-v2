using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetParcelItemsAction : IOrderSetParcelItemsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string ParcelKey { get; set; }

        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }
        public OrderSetParcelItemsAction()
        {
            this.Action = "setParcelItems";
        }
    }
}
