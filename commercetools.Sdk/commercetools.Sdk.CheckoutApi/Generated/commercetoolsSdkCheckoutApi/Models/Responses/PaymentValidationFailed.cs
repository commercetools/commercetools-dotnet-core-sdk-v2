using commercetools.Sdk.CheckoutApi.Models.Payments;


namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class PaymentValidationFailed : IPaymentValidationFailed
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public IPaymentReference Payload { get; set; }
        public PaymentValidationFailed()
        {
            this.Code = "payment_validation_failed";
        }
    }
}
