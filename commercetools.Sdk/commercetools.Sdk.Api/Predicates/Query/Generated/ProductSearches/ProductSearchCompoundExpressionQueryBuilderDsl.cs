using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchCompoundExpressionQueryBuilderDsl
    {
        public ProductSearchCompoundExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchCompoundExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchCompoundExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl> AsProductSearchAndExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAndExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAndExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAndExpressionQueryBuilderDsl.Of()),
                ProductSearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl> AsProductSearchFilterExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFilterExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFilterExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFilterExpressionQueryBuilderDsl.Of()),
                ProductSearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl> AsProductSearchNotExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNotExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNotExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNotExpressionQueryBuilderDsl.Of()),
                ProductSearchCompoundExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl> AsProductSearchOrExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchOrExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchOrExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchCompoundExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchOrExpressionQueryBuilderDsl.Of()),
                ProductSearchCompoundExpressionQueryBuilderDsl.Of);
        }
    }
}
