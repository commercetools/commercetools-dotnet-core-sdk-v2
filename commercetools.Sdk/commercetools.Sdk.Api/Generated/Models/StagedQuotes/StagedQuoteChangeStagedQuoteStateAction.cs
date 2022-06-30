namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    public partial class StagedQuoteChangeStagedQuoteStateAction : IStagedQuoteChangeStagedQuoteStateAction
    {
        public string Action { get; set; }

        public IStagedQuoteState StagedQuoteState { get; set; }
        public StagedQuoteChangeStagedQuoteStateAction()
        {
            this.Action = "changeStagedQuoteState";
        }
    }
}
