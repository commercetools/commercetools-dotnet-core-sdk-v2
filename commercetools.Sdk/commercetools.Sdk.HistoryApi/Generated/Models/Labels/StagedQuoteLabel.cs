using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class StagedQuoteLabel : IStagedQuoteLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public IReference Customer { get; set; }

        public IReference QuoteRequest { get; set; }
        public StagedQuoteLabel()
        {
            this.Type = "StagedQuoteLabel";
        }
    }
}
