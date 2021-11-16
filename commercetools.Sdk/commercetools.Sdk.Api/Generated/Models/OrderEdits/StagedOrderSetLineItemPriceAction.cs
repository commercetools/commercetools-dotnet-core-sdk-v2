using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLineItemPriceAction : IStagedOrderSetLineItemPriceAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        public StagedOrderSetLineItemPriceAction()
        { 
           this.Action = "setLineItemPrice";
        }
    }
}
