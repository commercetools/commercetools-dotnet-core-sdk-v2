

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetMethodInfoInterfaceAccountAction : IPaymentSetMethodInfoInterfaceAccountAction
    {
        public string Action { get; set; }

        public string InterfaceAccount { get; set; }
        public PaymentSetMethodInfoInterfaceAccountAction()
        {
            this.Action = "setMethodInfoInterfaceAccount";
        }
    }
}
