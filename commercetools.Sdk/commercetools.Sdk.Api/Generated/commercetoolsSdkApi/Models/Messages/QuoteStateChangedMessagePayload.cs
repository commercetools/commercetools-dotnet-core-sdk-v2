using commercetools.Sdk.Api.Models.Quotes;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteStateChangedMessagePayload : IQuoteStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IQuoteState QuoteState { get; set; }

        public IQuoteState OldQuoteState { get; set; }
        public QuoteStateChangedMessagePayload()
        {
            this.Type = "QuoteStateChanged";
        }
    }
}
