using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetMethodInfoNameAction : IPaymentSetMethodInfoNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public PaymentSetMethodInfoNameAction()
        { 
           this.Action = "setMethodInfoName";
        }
    }
}
