

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class FailedToRefreshSession : IFailedToRefreshSession
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public FailedToRefreshSession()
        {
            this.Code = "failed_to_refresh_session";
        }
    }
}
