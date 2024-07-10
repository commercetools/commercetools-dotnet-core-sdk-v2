namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetMethodInfoMethodAction : IPaymentSetMethodInfoMethodAction
    {
        public string Action { get; set; }

        public string Method { get; set; }
        public PaymentSetMethodInfoMethodAction()
        {
            this.Action = "setMethodInfoMethod";
        }
    }
}
