

namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestChangeQuoteRequestStateAction : IQuoteRequestChangeQuoteRequestStateAction
    {
        public string Action { get; set; }

        public IQuoteRequestState QuoteRequestState { get; set; }
        public QuoteRequestChangeQuoteRequestStateAction()
        {
            this.Action = "changeQuoteRequestState";
        }
    }
}
