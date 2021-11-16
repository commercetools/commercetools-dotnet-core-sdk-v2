namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetStatusInterfaceTextAction : IPaymentSetStatusInterfaceTextAction
    {
        public string Action { get; set;}
        
        public string InterfaceText { get; set;}
        public PaymentSetStatusInterfaceTextAction()
        { 
           this.Action = "setStatusInterfaceText";
        }
    }
}
