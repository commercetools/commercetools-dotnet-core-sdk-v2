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

        public IComparisonPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultBucketQueryBuilderDsl>(p, ProductSearchFacetResultBucketQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultBucketQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultBucketQueryBuilderDsl>(p, ProductSearchFacetResultBucketQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
