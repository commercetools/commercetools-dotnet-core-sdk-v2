

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ExpressPaymentInterrupted : IExpressPaymentInterrupted
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public ExpressPaymentInterrupted()
        {
            this.Code = "express_payment_interrupted";
        }
    }
}
