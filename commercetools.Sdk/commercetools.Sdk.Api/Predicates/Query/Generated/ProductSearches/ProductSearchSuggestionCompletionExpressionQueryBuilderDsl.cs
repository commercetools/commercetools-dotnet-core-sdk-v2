using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchSuggestionCompletionExpressionQueryBuilderDsl
    {
        public ProductSearchSuggestionCompletionExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchSuggestionCompletionExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchSuggestionCompletionExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchSuggestionCompletionExpressionQueryBuilderDsl> Completion(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchSuggestionCompletionExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("completion"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchSuggestionCompletionExpressionValueQueryBuilderDsl.Of())),
                ProductSearchSuggestionCompletionExpressionQueryBuilderDsl.Of);
        }


    }
}
