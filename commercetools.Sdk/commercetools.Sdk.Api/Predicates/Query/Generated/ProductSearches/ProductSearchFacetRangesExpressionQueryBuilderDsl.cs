using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetRangesExpressionQueryBuilderDsl
    {
        public ProductSearchFacetRangesExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetRangesExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetRangesExpressionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductSearchFacetRangesExpressionQueryBuilderDsl> Ranges(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetRangesExpressionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("ranges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesValueQueryBuilderDsl.Of())),
                ProductSearchFacetRangesExpressionQueryBuilderDsl.Of);
        }


    }
}
