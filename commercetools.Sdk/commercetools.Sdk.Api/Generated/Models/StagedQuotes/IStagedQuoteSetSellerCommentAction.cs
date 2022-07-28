using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetSellerCommentAction))]
    public partial interface IStagedQuoteSetSellerCommentAction : IStagedQuoteUpdateAction
    {
        string SellerComment { get; set; }

    }
}
