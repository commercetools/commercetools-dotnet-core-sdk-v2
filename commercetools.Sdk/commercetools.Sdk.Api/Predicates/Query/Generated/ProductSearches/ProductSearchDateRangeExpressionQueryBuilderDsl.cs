using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchDateRangeExpressionQueryBuilderDsl
    {
        public ProductSearchDateRangeExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchDateRangeExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchDateRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchDateRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchDateRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchDateRangeValueQueryBuilderDsl.Of())),
                ProductSearchDateRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
