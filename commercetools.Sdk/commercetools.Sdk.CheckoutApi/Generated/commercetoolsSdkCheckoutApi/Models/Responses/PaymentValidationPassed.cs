

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class PaymentValidationPassed : IPaymentValidationPassed
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public PaymentValidationPassed()
        {
            this.Code = "payment_validation_passed";
        }
    }
}
