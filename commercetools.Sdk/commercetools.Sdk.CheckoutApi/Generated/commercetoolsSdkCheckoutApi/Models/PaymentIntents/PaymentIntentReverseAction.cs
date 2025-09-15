

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{

    public partial class PaymentIntentReverseAction : IPaymentIntentReverseAction
    {
        public IPaymentIntentOperation Action { get; set; }

        public string MerchantReference { get; set; }
        public PaymentIntentReverseAction()
        {
            this.Action = IPaymentIntentOperation.FindEnum("reversePayment");
        }
    }
}
