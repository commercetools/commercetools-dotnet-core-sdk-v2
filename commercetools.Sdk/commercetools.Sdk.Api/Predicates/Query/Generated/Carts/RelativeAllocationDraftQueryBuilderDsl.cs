// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class RelativeAllocationDraftQueryBuilderDsl
    {
        public RelativeAllocationDraftQueryBuilderDsl()
        {
        }

        public static RelativeAllocationDraftQueryBuilderDsl Of()
        {
            return new RelativeAllocationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RelativeAllocationDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RelativeAllocationDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RelativeAllocationDraftQueryBuilderDsl>(p, RelativeAllocationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RelativeAllocationDraftQueryBuilderDsl, long> Percentage()
        {
            return new ComparisonPredicateBuilder<RelativeAllocationDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("percentage")),
            p => new CombinationQueryPredicate<RelativeAllocationDraftQueryBuilderDsl>(p, RelativeAllocationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
