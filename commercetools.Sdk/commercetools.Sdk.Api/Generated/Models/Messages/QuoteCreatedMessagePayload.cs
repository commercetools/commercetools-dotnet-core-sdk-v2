using commercetools.Sdk.Api.Models.Quotes;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteCreatedMessagePayload : IQuoteCreatedMessagePayload
    {
        public string Type { get; set; }

        public IQuote Quote { get; set; }
        public QuoteCreatedMessagePayload()
        {
            this.Type = "QuoteCreated";
        }
    }
}
