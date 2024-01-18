using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchTimeRangeExpressionQueryBuilderDsl
    {
        public ProductSearchTimeRangeExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchTimeRangeExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchTimeRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchTimeRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchTimeRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchTimeRangeValueQueryBuilderDsl.Of())),
                ProductSearchTimeRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
