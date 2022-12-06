using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderImportLineItemStateAction : IStagedOrderImportLineItemStateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IList<IItemState> State { get; set; }
        public IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }

        public StagedOrderImportLineItemStateAction()
        {
            this.Action = "importLineItemState";
        }
    }
}
