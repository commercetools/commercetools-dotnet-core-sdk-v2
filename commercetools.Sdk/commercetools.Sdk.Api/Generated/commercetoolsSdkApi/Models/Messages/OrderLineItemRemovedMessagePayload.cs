using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderLineItemRemovedMessagePayload : IOrderLineItemRemovedMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long RemovedQuantity { get; set; }

        public long NewQuantity { get; set; }

        public IList<IItemState> NewState { get; set; }

        public IEnumerable<IItemState> NewStateEnumerable { set => NewState = value.ToList(); }

        public ICentPrecisionMoney NewTotalPrice { get; set; }

        public ITaxedItemPrice NewTaxedPrice { get; set; }

        public IPrice NewPrice { get; set; }

        public IItemShippingDetails NewShippingDetail { get; set; }
        public OrderLineItemRemovedMessagePayload()
        {
            this.Type = "OrderLineItemRemoved";
        }
    }
}
