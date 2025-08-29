

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class PaymentFailureError : IPaymentFailureError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public PaymentFailureError()
        {
            this.Code = "PaymentFailure";
        }
    }
}
