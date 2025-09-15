using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class PaymentIntegrationSelectionConfirmationFailed : IPaymentIntegrationSelectionConfirmationFailed
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public PaymentIntegrationSelectionConfirmationFailed()
        {
            this.Code = "payment_integration_selection_confirmation_failed";
        }
    }
}
