using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetBucketResultQueryBuilderDsl
    {
        public ProductSearchFacetBucketResultQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetBucketResultQueryBuilderDsl Of()
        {
            return new ProductSearchFacetBucketResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetBucketResultQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetBucketResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetBucketResultQueryBuilderDsl>(p, ProductSearchFacetBucketResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchFacetBucketResultQueryBuilderDsl> Buckets(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchFacetBucketResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("buckets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchFacetResultBucketQueryBuilderDsl.Of())),
                ProductSearchFacetBucketResultQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchFacetBucketResultQueryBuilderDsl> Buckets()
        {
            return new CollectionPredicateBuilder<ProductSearchFacetBucketResultQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buckets")),
                    p => new CombinationQueryPredicate<ProductSearchFacetBucketResultQueryBuilderDsl>(p, ProductSearchFacetBucketResultQueryBuilderDsl.Of));
        }

    }
}
