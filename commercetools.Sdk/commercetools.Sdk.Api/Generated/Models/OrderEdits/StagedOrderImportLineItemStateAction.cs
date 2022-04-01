using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderImportLineItemStateAction : IStagedOrderImportLineItemStateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public List<IItemState> State { get; set; }
        public StagedOrderImportLineItemStateAction()
        {
            this.Action = "importLineItemState";
        }
    }
}
