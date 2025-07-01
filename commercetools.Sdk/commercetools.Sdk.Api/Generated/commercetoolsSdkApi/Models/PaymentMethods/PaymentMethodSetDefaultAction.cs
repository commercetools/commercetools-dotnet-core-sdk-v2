

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetDefaultAction : IPaymentMethodSetDefaultAction
    {
        public string Action { get; set; }

        public bool Default { get; set; }
        public PaymentMethodSetDefaultAction()
        {
            this.Action = "setDefault";
        }
    }
}
