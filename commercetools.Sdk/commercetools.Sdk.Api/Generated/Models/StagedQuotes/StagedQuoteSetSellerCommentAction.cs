namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    public partial class StagedQuoteSetSellerCommentAction : IStagedQuoteSetSellerCommentAction
    {
        public string Action { get; set; }

        public string SellerComment { get; set; }
        public StagedQuoteSetSellerCommentAction()
        {
            this.Action = "setSellerComment";
        }
    }
}
