namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetInterfaceIdAction : IPaymentSetInterfaceIdAction
    {
        public string Action { get; set; }

        public string InterfaceId { get; set; }
        public PaymentSetInterfaceIdAction()
        {
            this.Action = "setInterfaceId";
        }
    }
}
