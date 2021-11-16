using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLineItemTaxAmountAction : IStagedOrderSetLineItemTaxAmountAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public StagedOrderSetLineItemTaxAmountAction()
        { 
           this.Action = "setLineItemTaxAmount";
        }
    }
}
