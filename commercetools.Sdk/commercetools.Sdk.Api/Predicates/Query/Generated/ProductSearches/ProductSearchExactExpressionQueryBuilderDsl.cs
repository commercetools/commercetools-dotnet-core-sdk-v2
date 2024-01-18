using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchExactExpressionQueryBuilderDsl
    {
        public ProductSearchExactExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchExactExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchExactExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchExactExpressionQueryBuilderDsl> Exact(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchExactExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("exact"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl.Of())),
                ProductSearchExactExpressionQueryBuilderDsl.Of);
        }


    }
}
