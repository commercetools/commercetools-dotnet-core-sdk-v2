using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchQueryQueryBuilderDsl
    {
        public ProductSearchQueryQueryBuilderDsl()
        {
        }

        public static ProductSearchQueryQueryBuilderDsl Of()
        {
            return new ProductSearchQueryQueryBuilderDsl();
        }


        public CombinationQueryPredicate<ProductSearchQueryQueryBuilderDsl> AsProductSearchCompoundExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchCompoundExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchCompoundExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchCompoundExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchQueryQueryBuilderDsl> AsProductSearchQueryExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchQueryQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchQueryExpressionQueryBuilderDsl.Of()),
                ProductSearchQueryQueryBuilderDsl.Of);
        }
    }
}
