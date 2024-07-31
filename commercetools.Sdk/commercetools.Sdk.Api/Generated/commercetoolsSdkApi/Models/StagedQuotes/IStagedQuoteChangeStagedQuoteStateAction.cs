using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteChangeStagedQuoteStateAction))]
    public partial interface IStagedQuoteChangeStagedQuoteStateAction : IStagedQuoteUpdateAction
    {
        IStagedQuoteState StagedQuoteState { get; set; }

    }
}
