

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetPaymentMethodStatusAction : IPaymentMethodSetPaymentMethodStatusAction
    {
        public string Action { get; set; }

        public IPaymentMethodStatus PaymentMethodStatus { get; set; }
        public PaymentMethodSetPaymentMethodStatusAction()
        {
            this.Action = "setPaymentMethodStatus";
        }
    }
}
