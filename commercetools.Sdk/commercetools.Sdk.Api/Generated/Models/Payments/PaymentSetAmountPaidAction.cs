using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetAmountPaidAction : IPaymentSetAmountPaidAction
    {
        public string Action { get; set;}
        
        public IMoney Amount { get; set;}
        public PaymentSetAmountPaidAction()
        { 
           this.Action = "setAmountPaid";
        }
    }
}
