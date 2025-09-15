

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class OrderVerificationStarted : IOrderVerificationStarted
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public OrderVerificationStarted()
        {
            this.Code = "order_verification_started";
        }
    }
}
