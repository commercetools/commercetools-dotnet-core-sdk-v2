using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderImportLineItemStateAction : IOrderImportLineItemStateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        public OrderImportLineItemStateAction()
        {
            this.Action = "importLineItemState";
        }
    }
}
