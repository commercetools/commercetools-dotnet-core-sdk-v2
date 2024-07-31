using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderImportCustomLineItemStateAction : IOrderImportCustomLineItemStateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IList<IItemState> State { get; set; }

        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }
        public OrderImportCustomLineItemStateAction()
        {
            this.Action = "importCustomLineItemState";
        }
    }
}
