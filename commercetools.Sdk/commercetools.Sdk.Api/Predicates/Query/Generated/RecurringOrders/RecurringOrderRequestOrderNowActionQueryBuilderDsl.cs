// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderRequestOrderNowActionQueryBuilderDsl
    {
        public RecurringOrderRequestOrderNowActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderRequestOrderNowActionQueryBuilderDsl Of()
        {
            return new RecurringOrderRequestOrderNowActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderRequestOrderNowActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderRequestOrderNowActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderRequestOrderNowActionQueryBuilderDsl>(p, RecurringOrderRequestOrderNowActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderRequestOrderNowActionQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<RecurringOrderRequestOrderNowActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<RecurringOrderRequestOrderNowActionQueryBuilderDsl>(p, RecurringOrderRequestOrderNowActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
