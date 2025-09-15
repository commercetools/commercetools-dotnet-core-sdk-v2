using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{

    public partial class PaymentIntentCaptureAction : IPaymentIntentCaptureAction
    {
        public IPaymentIntentOperation Action { get; set; }

        public IAmount Amount { get; set; }

        public string MerchantReference { get; set; }
        public PaymentIntentCaptureAction()
        {
            this.Action = IPaymentIntentOperation.FindEnum("capturePayment");
        }
    }
}
