using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{

    public partial class PaymentIntentRefundAction : IPaymentIntentRefundAction
    {
        public IPaymentIntentOperation Action { get; set; }

        public IAmount Amount { get; set; }

        public string TransactionId { get; set; }

        public string MerchantReference { get; set; }
        public PaymentIntentRefundAction()
        {
            this.Action = IPaymentIntentOperation.FindEnum("refundPayment");
        }
    }
}
