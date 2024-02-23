namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteRequestQuoteRenegotiationAction : IQuoteRequestQuoteRenegotiationAction
    {
        public string Action { get; set; }

        public string BuyerComment { get; set; }
        public QuoteRequestQuoteRenegotiationAction()
        {
            this.Action = "requestQuoteRenegotiation";
        }
    }
}
