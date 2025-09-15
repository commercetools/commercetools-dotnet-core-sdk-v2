

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{

    public partial class PaymentIntentCancelAction : IPaymentIntentCancelAction
    {
        public IPaymentIntentOperation Action { get; set; }

        public string MerchantReference { get; set; }
        public PaymentIntentCancelAction()
        {
            this.Action = IPaymentIntentOperation.FindEnum("cancelPayment");
        }
    }
}
