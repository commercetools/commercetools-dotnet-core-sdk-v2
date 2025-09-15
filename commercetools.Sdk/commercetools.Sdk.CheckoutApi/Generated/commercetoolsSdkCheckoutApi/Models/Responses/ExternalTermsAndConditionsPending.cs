

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ExternalTermsAndConditionsPending : IExternalTermsAndConditionsPending
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public ExternalTermsAndConditionsPending()
        {
            this.Code = "external_terms_and_conditions_pending";
        }
    }
}
