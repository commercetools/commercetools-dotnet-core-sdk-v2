

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class NoExpressPaymentIntegrations : INoExpressPaymentIntegrations
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public NoExpressPaymentIntegrations()
        {
            this.Code = "no_express_payment_integrations";
        }
    }
}
