using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderSetScheduleActionQueryBuilderDsl
    {
        public RecurringOrderSetScheduleActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderSetScheduleActionQueryBuilderDsl Of()
        {
            return new RecurringOrderSetScheduleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderSetScheduleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetScheduleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderSetScheduleActionQueryBuilderDsl>(p, RecurringOrderSetScheduleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderSetScheduleActionQueryBuilderDsl> RecurrencePolicy(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderSetScheduleActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of())),
                RecurringOrderSetScheduleActionQueryBuilderDsl.Of);
        }


    }
}
