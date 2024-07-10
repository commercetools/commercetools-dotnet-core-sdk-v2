using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetExpressionQueryBuilderDsl
    {
        public ProductSearchFacetExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetExpressionQueryBuilderDsl();
        }


        public CombinationQueryPredicate<ProductSearchFacetExpressionQueryBuilderDsl> AsProductSearchFacetCountExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetCountExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetCountExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetCountExpressionQueryBuilderDsl.Of()),
                ProductSearchFacetExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchFacetExpressionQueryBuilderDsl> AsProductSearchFacetDistinctExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetDistinctExpressionQueryBuilderDsl.Of()),
                ProductSearchFacetExpressionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductSearchFacetExpressionQueryBuilderDsl> AsProductSearchFacetRangesExpression(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesExpressionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesExpressionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetExpressionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetRangesExpressionQueryBuilderDsl.Of()),
                ProductSearchFacetExpressionQueryBuilderDsl.Of);
        }
    }
}
