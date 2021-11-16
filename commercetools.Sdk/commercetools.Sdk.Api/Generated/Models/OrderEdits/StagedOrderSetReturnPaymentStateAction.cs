using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetReturnPaymentStateAction : IStagedOrderSetReturnPaymentStateAction
    {
        public string Action { get; set;}
        
        public string ReturnItemId { get; set;}
        
        public IReturnPaymentState PaymentState { get; set;}
        public StagedOrderSetReturnPaymentStateAction()
        { 
           this.Action = "setReturnPaymentState";
        }
    }
}
