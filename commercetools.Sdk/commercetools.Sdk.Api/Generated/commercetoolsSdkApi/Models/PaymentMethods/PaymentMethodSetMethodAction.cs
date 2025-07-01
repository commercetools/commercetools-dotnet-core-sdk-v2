

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetMethodAction : IPaymentMethodSetMethodAction
    {
        public string Action { get; set; }

        public string Method { get; set; }
        public PaymentMethodSetMethodAction()
        {
            this.Action = "setMethod";
        }
    }
}
