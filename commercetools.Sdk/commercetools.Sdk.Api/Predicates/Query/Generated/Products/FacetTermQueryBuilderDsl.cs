// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class FacetTermQueryBuilderDsl
    {
        public FacetTermQueryBuilderDsl()
        {
        }

        public static FacetTermQueryBuilderDsl Of()
        {
            return new FacetTermQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<FacetTermQueryBuilderDsl, string> Term()
        {
            return new ComparisonPredicateBuilder<FacetTermQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("term")),
            p => new CombinationQueryPredicate<FacetTermQueryBuilderDsl>(p, FacetTermQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetTermQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<FacetTermQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<FacetTermQueryBuilderDsl>(p, FacetTermQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<FacetTermQueryBuilderDsl, long> ProductCount()
        {
            return new ComparisonPredicateBuilder<FacetTermQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productCount")),
            p => new CombinationQueryPredicate<FacetTermQueryBuilderDsl>(p, FacetTermQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
