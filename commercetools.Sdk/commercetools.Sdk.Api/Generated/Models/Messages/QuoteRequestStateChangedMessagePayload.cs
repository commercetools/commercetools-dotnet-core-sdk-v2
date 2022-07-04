using commercetools.Sdk.Api.Models.QuoteRequests;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class QuoteRequestStateChangedMessagePayload : IQuoteRequestStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IQuoteRequestState QuoteRequestState { get; set; }

        public IQuoteRequestState OldQuoteRequestState { get; set; }
        public QuoteRequestStateChangedMessagePayload()
        {
            this.Type = "QuoteRequestStateChanged";
        }
    }
}
