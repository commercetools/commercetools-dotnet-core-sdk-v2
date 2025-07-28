using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderUpdateActionQueryBuilderDsl
    {
        public RecurringOrderUpdateActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderUpdateActionQueryBuilderDsl Of()
        {
            return new RecurringOrderUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(p, RecurringOrderUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetCustomFieldActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetCustomTypeActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetExpiresAt(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetExpiresAtActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetExpiresAtActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetExpiresAtActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetKeyActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetOrderSkipConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetOrderSkipConfigurationActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetSchedule(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetScheduleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetScheduleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetScheduleActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetStartsAt(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetStartsAtActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetStartsAtActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetStartsAtActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsSetRecurringOrderState(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderSetStateActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderTransitionStateActionQueryBuilderDsl.Of()),
                RecurringOrderUpdateActionQueryBuilderDsl.Of);
        }
    }
}
