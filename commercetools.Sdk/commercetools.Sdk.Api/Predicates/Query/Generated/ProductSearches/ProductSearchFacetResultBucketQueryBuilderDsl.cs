using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultBucketQueryBuilderDsl
    {
        public ProductSearchFacetResultBucketQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultBucketQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultBucketQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultBucketQueryBuilderDsl>(p, ProductSearchFacetResultBucketQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetResultBucketQueryBuilderDsl> Buckets(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetResultBucketQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("buckets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketEntryQueryBuilderDsl.Of())),
                ProductSearchFacetResultBucketQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl> Buckets()
        {
            return new CollectionPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buckets")),
                    p => new CombinationQueryPredicate<ProductSearchFacetResultBucketQueryBuilderDsl>(p, ProductSearchFacetResultBucketQueryBuilderDsl.Of));
        }

    }
}
