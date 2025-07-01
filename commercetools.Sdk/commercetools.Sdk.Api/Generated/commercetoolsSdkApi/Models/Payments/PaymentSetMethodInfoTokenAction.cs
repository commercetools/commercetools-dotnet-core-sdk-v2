using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetMethodInfoTokenAction : IPaymentSetMethodInfoTokenAction
    {
        public string Action { get; set; }

        public IPaymentMethodToken Token { get; set; }
        public PaymentSetMethodInfoTokenAction()
        {
            this.Action = "setMethodInfoToken";
        }
    }
}
