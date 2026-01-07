using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ExpressPaymentIntegrationNotAvailable : IExpressPaymentIntegrationNotAvailable
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public ExpressPaymentIntegrationNotAvailable()
        {
            this.Code = "express_payment_integration_not_available";
        }
    }
}
