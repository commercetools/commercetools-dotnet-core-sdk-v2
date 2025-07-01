

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetInterfaceAccountAction : IPaymentMethodSetInterfaceAccountAction
    {
        public string Action { get; set; }

        public string InterfaceAccount { get; set; }
        public PaymentMethodSetInterfaceAccountAction()
        {
            this.Action = "setInterfaceAccount";
        }
    }
}
