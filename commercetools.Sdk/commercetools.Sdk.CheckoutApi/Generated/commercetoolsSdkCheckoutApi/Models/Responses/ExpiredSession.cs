

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ExpiredSession : IExpiredSession
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public ExpiredSession()
        {
            this.Code = "expired_session";
        }
    }
}
