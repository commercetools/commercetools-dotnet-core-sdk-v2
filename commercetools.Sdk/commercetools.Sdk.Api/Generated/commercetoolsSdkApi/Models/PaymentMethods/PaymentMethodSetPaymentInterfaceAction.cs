

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetPaymentInterfaceAction : IPaymentMethodSetPaymentInterfaceAction
    {
        public string Action { get; set; }

        public string PaymentInterface { get; set; }
        public PaymentMethodSetPaymentInterfaceAction()
        {
            this.Action = "setPaymentInterface";
        }
    }
}
