

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class CheckoutCancelled : ICheckoutCancelled
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public CheckoutCancelled()
        {
            this.Code = "checkout_cancelled";
        }
    }
}
