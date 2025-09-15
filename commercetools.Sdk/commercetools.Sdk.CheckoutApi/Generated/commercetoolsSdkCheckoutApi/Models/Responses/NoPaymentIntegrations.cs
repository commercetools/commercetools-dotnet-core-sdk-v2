

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class NoPaymentIntegrations : INoPaymentIntegrations
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public NoPaymentIntegrations()
        {
            this.Code = "no_payment_integrations";
        }
    }
}
