

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class CheckoutStarted : ICheckoutStarted
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public CheckoutStarted()
        {
            this.Code = "checkout_started";
        }
    }
}
