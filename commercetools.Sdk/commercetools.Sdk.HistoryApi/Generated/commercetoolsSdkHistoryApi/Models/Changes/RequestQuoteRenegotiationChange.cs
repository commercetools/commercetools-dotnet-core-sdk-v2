using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RequestQuoteRenegotiationChange : IRequestQuoteRenegotiationChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IQuoteState PreviousValue { get; set; }

        public IQuoteState NextValue { get; set; }

        public string BuyerComment { get; set; }
        public RequestQuoteRenegotiationChange()
        {
            this.Type = "RequestQuoteRenegotiationChange";
        }
    }
}
