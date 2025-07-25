using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl>(p, RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl> RecurrencePolicySchedule(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicySchedule"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleQueryBuilderDsl.Of())),
                RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl> OldRecurrencePolicySchedule(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldRecurrencePolicySchedule"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleQueryBuilderDsl.Of())),
                RecurringOrderScheduleSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
