using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchWildCardExpressionQueryBuilderDsl
    {
        public ProductSearchWildCardExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchWildCardExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchWildCardExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchWildCardExpressionQueryBuilderDsl> Wildcard(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchWildCardExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("wildcard"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl.Of())),
                ProductSearchWildCardExpressionQueryBuilderDsl.Of);
        }


    }
}
