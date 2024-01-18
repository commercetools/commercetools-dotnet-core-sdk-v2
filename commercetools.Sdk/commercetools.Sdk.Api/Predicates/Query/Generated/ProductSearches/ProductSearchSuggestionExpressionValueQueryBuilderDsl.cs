using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchSuggestionExpressionValueQueryBuilderDsl
    {
        public ProductSearchSuggestionExpressionValueQueryBuilderDsl()
        {
        }

        public static ProductSearchSuggestionExpressionValueQueryBuilderDsl Of()
        {
            return new ProductSearchSuggestionExpressionValueQueryBuilderDsl();
        }


        public CombinationQueryPredicate<ProductSearchSuggestionExpressionValueQueryBuilderDsl> AsProductSearchSuggestionCompletionExpressionValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchSuggestionExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl.Of()),
                ProductSearchSuggestionExpressionValueQueryBuilderDsl.Of);
        }
    }
}
