namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentSetMethodInfoInterfaceAction : IPaymentSetMethodInfoInterfaceAction
    {
        public string Action { get; set; }

        public string Interface { get; set; }
        public PaymentSetMethodInfoInterfaceAction()
        {
            this.Action = "setMethodInfoInterface";
        }
    }
}
