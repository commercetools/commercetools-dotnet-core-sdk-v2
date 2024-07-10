using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl
    {
        public ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl Of()
        {
            return new ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl, string> By()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("by")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl>(p, ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl, string> Order()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("order")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl>(p, ProductSearchFacetDistinctBucketSortExpressionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
