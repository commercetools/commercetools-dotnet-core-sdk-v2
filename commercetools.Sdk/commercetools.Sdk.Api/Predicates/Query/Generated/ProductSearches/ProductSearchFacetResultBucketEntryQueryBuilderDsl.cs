// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultBucketEntryQueryBuilderDsl
    {
        public ProductSearchFacetResultBucketEntryQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultBucketEntryQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultBucketEntryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetResultBucketEntryQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultBucketEntryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultBucketEntryQueryBuilderDsl>(p, ProductSearchFacetResultBucketEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultBucketEntryQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultBucketEntryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultBucketEntryQueryBuilderDsl>(p, ProductSearchFacetResultBucketEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
