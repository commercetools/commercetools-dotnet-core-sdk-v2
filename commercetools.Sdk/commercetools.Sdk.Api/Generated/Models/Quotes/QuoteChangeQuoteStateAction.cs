namespace commercetools.Sdk.Api.Models.Quotes
{
    public partial class QuoteChangeQuoteStateAction : IQuoteChangeQuoteStateAction
    {
        public string Action { get; set; }

        public IQuoteState QuoteState { get; set; }
        public QuoteChangeQuoteStateAction()
        {
            this.Action = "changeQuoteState";
        }
    }
}
