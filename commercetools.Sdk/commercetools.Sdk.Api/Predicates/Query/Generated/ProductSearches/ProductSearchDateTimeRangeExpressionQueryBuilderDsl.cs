using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchDateTimeRangeExpressionQueryBuilderDsl
    {
        public ProductSearchDateTimeRangeExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchDateTimeRangeExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchDateTimeRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchDateTimeRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchDateTimeRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateTimeRangeValueQueryBuilderDsl.Of())),
                ProductSearchDateTimeRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
