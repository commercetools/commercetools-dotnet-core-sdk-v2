// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderSetKeyActionQueryBuilderDsl
    {
        public RecurringOrderSetKeyActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderSetKeyActionQueryBuilderDsl Of()
        {
            return new RecurringOrderSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderSetKeyActionQueryBuilderDsl>(p, RecurringOrderSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<RecurringOrderSetKeyActionQueryBuilderDsl>(p, RecurringOrderSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
