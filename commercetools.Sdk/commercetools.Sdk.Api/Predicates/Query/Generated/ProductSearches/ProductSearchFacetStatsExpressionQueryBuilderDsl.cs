using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetStatsExpressionQueryBuilderDsl
    {
        public ProductSearchFacetStatsExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetStatsExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetStatsExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFacetStatsExpressionQueryBuilderDsl> Stats(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetStatsValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetStatsValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetStatsExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stats"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetStatsValueQueryBuilderDsl.Of())),
                ProductSearchFacetStatsExpressionQueryBuilderDsl.Of);
        }


    }
}
