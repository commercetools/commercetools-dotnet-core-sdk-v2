using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartChangeLineItemQuantityAction : IMyCartChangeLineItemQuantityAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        
        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        public MyCartChangeLineItemQuantityAction()
        { 
           this.Action = "changeLineItemQuantity";
        }
    }
}
