using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeStagedQuoteStateChange : IChangeStagedQuoteStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IStagedQuoteState PreviousValue { get; set; }

        public IStagedQuoteState NextValue { get; set; }
        public ChangeStagedQuoteStateChange()
        {
            this.Type = "ChangeStagedQuoteStateChange";
        }
    }
}
