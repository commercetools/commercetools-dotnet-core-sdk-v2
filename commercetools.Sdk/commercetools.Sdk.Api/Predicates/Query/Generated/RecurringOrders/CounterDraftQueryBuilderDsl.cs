// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class CounterDraftQueryBuilderDsl
    {
        public CounterDraftQueryBuilderDsl()
        {
        }

        public static CounterDraftQueryBuilderDsl Of()
        {
            return new CounterDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CounterDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CounterDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CounterDraftQueryBuilderDsl>(p, CounterDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CounterDraftQueryBuilderDsl, long> TotalToSkip()
        {
            return new ComparisonPredicateBuilder<CounterDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("totalToSkip")),
            p => new CombinationQueryPredicate<CounterDraftQueryBuilderDsl>(p, CounterDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
