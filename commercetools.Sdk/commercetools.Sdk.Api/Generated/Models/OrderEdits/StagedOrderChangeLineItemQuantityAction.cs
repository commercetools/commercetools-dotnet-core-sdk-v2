using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeLineItemQuantityAction : IStagedOrderChangeLineItemQuantityAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public double Quantity { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        
        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        public StagedOrderChangeLineItemQuantityAction()
        { 
           this.Action = "changeLineItemQuantity";
        }
    }
}
