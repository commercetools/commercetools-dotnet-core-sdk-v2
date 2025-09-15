

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class OrderVerificationTimeout : IOrderVerificationTimeout
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public OrderVerificationTimeout()
        {
            this.Code = "order_verification_timeout";
        }
    }
}
