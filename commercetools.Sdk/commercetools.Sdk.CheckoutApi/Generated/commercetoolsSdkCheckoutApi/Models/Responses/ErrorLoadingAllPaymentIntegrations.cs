

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ErrorLoadingAllPaymentIntegrations : IErrorLoadingAllPaymentIntegrations
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public ErrorLoadingAllPaymentIntegrations()
        {
            this.Code = "error_loading_all_payment_integrations";
        }
    }
}
