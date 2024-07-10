using commercetools.Sdk.Api.Models.StagedQuotes;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteCreatedMessagePayload : IStagedQuoteCreatedMessagePayload
    {
        public string Type { get; set; }

        public IStagedQuote StagedQuote { get; set; }
        public StagedQuoteCreatedMessagePayload()
        {
            this.Type = "StagedQuoteCreated";
        }
    }
}
