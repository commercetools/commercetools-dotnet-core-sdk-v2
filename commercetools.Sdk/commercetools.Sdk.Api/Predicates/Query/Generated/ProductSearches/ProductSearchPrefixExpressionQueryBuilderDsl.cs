using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchPrefixExpressionQueryBuilderDsl
    {
        public ProductSearchPrefixExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchPrefixExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchPrefixExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchPrefixExpressionQueryBuilderDsl> Prefix(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchPrefixExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prefix"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchAnyValueQueryBuilderDsl.Of())),
                ProductSearchPrefixExpressionQueryBuilderDsl.Of);
        }


    }
}
