using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderImportCustomLineItemStateAction : IStagedOrderImportCustomLineItemStateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public List<IItemState> State { get; set; }
        public StagedOrderImportCustomLineItemStateAction()
        {
            this.Action = "importCustomLineItemState";
        }
    }
}
