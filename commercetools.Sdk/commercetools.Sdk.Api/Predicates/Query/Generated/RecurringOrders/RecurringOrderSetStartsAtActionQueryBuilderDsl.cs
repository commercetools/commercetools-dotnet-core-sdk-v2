using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderSetStartsAtActionQueryBuilderDsl
    {
        public RecurringOrderSetStartsAtActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderSetStartsAtActionQueryBuilderDsl Of()
        {
            return new RecurringOrderSetStartsAtActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderSetStartsAtActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetStartsAtActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderSetStartsAtActionQueryBuilderDsl>(p, RecurringOrderSetStartsAtActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderSetStartsAtActionQueryBuilderDsl, DateTime> StartsAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetStartsAtActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("startsAt")),
            p => new CombinationQueryPredicate<RecurringOrderSetStartsAtActionQueryBuilderDsl>(p, RecurringOrderSetStartsAtActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
