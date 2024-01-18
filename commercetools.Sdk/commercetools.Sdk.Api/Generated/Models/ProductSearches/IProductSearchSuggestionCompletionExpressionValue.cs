using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchSuggestionCompletionExpressionValue))]
    public partial interface IProductSearchSuggestionCompletionExpressionValue : IProductSearchSuggestionExpressionValue
    {
        string Name { get; set; }

        string Field { get; set; }

        string Prefix { get; set; }

    }
}
