// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultStatsQueryBuilderDsl
    {
        public ProductSearchFacetResultStatsQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultStatsQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultStatsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultStatsQueryBuilderDsl>(p, ProductSearchFacetResultStatsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string> Min()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("min")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultStatsQueryBuilderDsl>(p, ProductSearchFacetResultStatsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string> Max()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("max")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultStatsQueryBuilderDsl>(p, ProductSearchFacetResultStatsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string> Mean()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mean")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultStatsQueryBuilderDsl>(p, ProductSearchFacetResultStatsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string> Sum()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sum")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultStatsQueryBuilderDsl>(p, ProductSearchFacetResultStatsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultStatsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultStatsQueryBuilderDsl>(p, ProductSearchFacetResultStatsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
