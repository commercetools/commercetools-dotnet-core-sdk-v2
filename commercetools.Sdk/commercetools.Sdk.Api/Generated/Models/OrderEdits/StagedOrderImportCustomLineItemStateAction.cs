using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderImportCustomLineItemStateAction : IStagedOrderImportCustomLineItemStateAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public List<IItemState> State { get; set;}
        public StagedOrderImportCustomLineItemStateAction()
        { 
           this.Action = "importCustomLineItemState";
        }
    }
}
