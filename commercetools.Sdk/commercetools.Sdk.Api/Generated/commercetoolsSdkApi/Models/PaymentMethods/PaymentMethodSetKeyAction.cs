

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetKeyAction : IPaymentMethodSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public PaymentMethodSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
