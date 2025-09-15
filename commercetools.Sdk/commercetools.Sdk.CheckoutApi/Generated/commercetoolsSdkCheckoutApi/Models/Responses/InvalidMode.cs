

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class InvalidMode : IInvalidMode
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public InvalidMode()
        {
            this.Code = "invalid_mode";
        }
    }
}
