using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchSuggestionCompletionExpression))]
    public partial interface IProductSearchSuggestionCompletionExpression : IProductSearchSuggestionExpression
    {
        IProductSearchSuggestionCompletionExpressionValue Completion { get; set; }

    }
}
