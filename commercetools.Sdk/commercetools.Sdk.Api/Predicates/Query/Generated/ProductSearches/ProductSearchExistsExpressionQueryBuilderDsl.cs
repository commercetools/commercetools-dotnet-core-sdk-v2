using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchExistsExpressionQueryBuilderDsl
    {
        public ProductSearchExistsExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchExistsExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchExistsExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchExistsExpressionQueryBuilderDsl> Exists(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchExistsExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("exists"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchExistsValueQueryBuilderDsl.Of())),
                ProductSearchExistsExpressionQueryBuilderDsl.Of);
        }


    }
}
