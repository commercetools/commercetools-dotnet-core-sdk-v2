using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderSetExpiresAtActionQueryBuilderDsl
    {
        public RecurringOrderSetExpiresAtActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderSetExpiresAtActionQueryBuilderDsl Of()
        {
            return new RecurringOrderSetExpiresAtActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderSetExpiresAtActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetExpiresAtActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderSetExpiresAtActionQueryBuilderDsl>(p, RecurringOrderSetExpiresAtActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderSetExpiresAtActionQueryBuilderDsl, DateTime> ExpiresAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetExpiresAtActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expiresAt")),
            p => new CombinationQueryPredicate<RecurringOrderSetExpiresAtActionQueryBuilderDsl>(p, RecurringOrderSetExpiresAtActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
