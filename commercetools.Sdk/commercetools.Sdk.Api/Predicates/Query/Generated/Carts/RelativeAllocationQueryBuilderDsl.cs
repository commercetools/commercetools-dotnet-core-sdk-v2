// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class RelativeAllocationQueryBuilderDsl
    {
        public RelativeAllocationQueryBuilderDsl()
        {
        }

        public static RelativeAllocationQueryBuilderDsl Of()
        {
            return new RelativeAllocationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RelativeAllocationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RelativeAllocationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RelativeAllocationQueryBuilderDsl>(p, RelativeAllocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RelativeAllocationQueryBuilderDsl, long> Percentage()
        {
            return new ComparisonPredicateBuilder<RelativeAllocationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("percentage")),
            p => new CombinationQueryPredicate<RelativeAllocationQueryBuilderDsl>(p, RelativeAllocationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
