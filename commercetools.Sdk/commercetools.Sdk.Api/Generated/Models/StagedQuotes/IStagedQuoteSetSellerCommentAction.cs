using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetSellerCommentAction))]
    public partial interface IStagedQuoteSetSellerCommentAction : IStagedQuoteUpdateAction
    {
        string SellerComment { get; set; }

    }
}
