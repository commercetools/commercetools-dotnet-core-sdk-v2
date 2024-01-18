using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchNumberRangeExpressionQueryBuilderDsl
    {
        public ProductSearchNumberRangeExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchNumberRangeExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchNumberRangeExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchNumberRangeExpressionQueryBuilderDsl> Range(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchNumberRangeExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("range"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchNumberRangeValueQueryBuilderDsl.Of())),
                ProductSearchNumberRangeExpressionQueryBuilderDsl.Of);
        }


    }
}
