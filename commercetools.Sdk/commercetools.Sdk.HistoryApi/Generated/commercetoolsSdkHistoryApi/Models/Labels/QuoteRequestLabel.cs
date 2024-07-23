using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class QuoteRequestLabel : IQuoteRequestLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public IReference Customer { get; set; }
        public QuoteRequestLabel()
        {
            this.Type = "QuoteRequestLabel";
        }
    }
}
