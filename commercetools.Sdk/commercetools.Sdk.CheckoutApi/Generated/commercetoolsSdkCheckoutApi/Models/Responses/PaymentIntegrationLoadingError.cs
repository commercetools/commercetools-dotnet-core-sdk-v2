using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class PaymentIntegrationLoadingError : IPaymentIntegrationLoadingError
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public PaymentIntegrationLoadingError()
        {
            this.Code = "payment_integration_loading_error";
        }
    }
}
