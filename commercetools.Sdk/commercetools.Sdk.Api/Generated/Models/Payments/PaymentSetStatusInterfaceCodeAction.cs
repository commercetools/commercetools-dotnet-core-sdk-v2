namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetStatusInterfaceCodeAction : IPaymentSetStatusInterfaceCodeAction
    {
        public string Action { get; set; }

        public string InterfaceCode { get; set; }
        public PaymentSetStatusInterfaceCodeAction()
        {
            this.Action = "setStatusInterfaceCode";
        }
    }
}
