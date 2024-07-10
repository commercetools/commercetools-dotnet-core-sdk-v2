using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeQuoteRequestStateChange : IChangeQuoteRequestStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IQuoteRequestState PreviousValue { get; set; }

        public IQuoteRequestState NextValue { get; set; }
        public ChangeQuoteRequestStateChange()
        {
            this.Type = "ChangeQuoteRequestStateChange";
        }
    }
}
