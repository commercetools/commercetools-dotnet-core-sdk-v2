// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class FilteredFacetResultQueryBuilderDsl
    {
        public FilteredFacetResultQueryBuilderDsl()
        {
        }

        public static FilteredFacetResultQueryBuilderDsl Of()
        {
            return new FilteredFacetResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<FilteredFacetResultQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<FilteredFacetResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<FilteredFacetResultQueryBuilderDsl>(p, FilteredFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FilteredFacetResultQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<FilteredFacetResultQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<FilteredFacetResultQueryBuilderDsl>(p, FilteredFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FilteredFacetResultQueryBuilderDsl, long> ProductCount()
        {
            return new ComparisonPredicateBuilder<FilteredFacetResultQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productCount")),
            p => new CombinationQueryPredicate<FilteredFacetResultQueryBuilderDsl>(p, FilteredFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
