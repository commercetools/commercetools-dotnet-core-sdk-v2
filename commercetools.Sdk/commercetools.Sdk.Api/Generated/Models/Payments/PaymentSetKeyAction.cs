namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetKeyAction : IPaymentSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public PaymentSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
