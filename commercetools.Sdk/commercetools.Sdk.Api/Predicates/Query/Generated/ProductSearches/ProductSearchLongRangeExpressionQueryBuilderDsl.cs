using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchLongRangeExpressionQueryBuilderDsl
    {
        public ProductSearchLongRangeExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchLongRangeExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchLongRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchLongRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchLongRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchLongRangeValueQueryBuilderDsl.Of())),
                ProductSearchLongRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
