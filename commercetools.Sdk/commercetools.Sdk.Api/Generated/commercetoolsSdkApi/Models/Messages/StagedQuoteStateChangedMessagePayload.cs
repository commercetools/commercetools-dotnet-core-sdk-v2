using commercetools.Sdk.Api.Models.StagedQuotes;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteStateChangedMessagePayload : IStagedQuoteStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IStagedQuoteState StagedQuoteState { get; set; }

        public IStagedQuoteState OldStagedQuoteState { get; set; }
        public StagedQuoteStateChangedMessagePayload()
        {
            this.Type = "StagedQuoteStateChanged";
        }
    }
}
