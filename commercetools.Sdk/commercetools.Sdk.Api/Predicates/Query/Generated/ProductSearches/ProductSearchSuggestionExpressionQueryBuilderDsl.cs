using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchSuggestionExpressionQueryBuilderDsl
    {
        public ProductSearchSuggestionExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchSuggestionExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchSuggestionExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<ProductSearchSuggestionExpressionQueryBuilderDsl> AsProductSearchSuggestionCompletionExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchSuggestionExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionQueryBuilderDsl.Of()),
                ProductSearchSuggestionExpressionQueryBuilderDsl.Of);
        }
    }
}
