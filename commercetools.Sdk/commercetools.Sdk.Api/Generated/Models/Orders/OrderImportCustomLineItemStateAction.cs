using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderImportCustomLineItemStateAction : IOrderImportCustomLineItemStateAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public List<IItemState> State { get; set;}
        public OrderImportCustomLineItemStateAction()
        { 
           this.Action = "importCustomLineItemState";
        }
    }
}
