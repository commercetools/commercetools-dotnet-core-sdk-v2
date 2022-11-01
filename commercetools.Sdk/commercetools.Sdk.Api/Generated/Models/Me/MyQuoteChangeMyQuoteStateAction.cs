namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteChangeMyQuoteStateAction : IMyQuoteChangeMyQuoteStateAction
    {
        public string Action { get; set; }

        public IMyQuoteState QuoteState { get; set; }
        public MyQuoteChangeMyQuoteStateAction()
        {
            this.Action = "changeMyQuoteState";
        }
    }
}
