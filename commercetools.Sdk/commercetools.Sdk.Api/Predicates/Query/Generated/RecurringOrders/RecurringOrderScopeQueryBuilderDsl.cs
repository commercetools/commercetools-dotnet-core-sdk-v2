using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderScopeQueryBuilderDsl
    {
        public RecurringOrderScopeQueryBuilderDsl()
        {
        }

        public static RecurringOrderScopeQueryBuilderDsl Of()
        {
            return new RecurringOrderScopeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderScopeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderScopeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl>(p, RecurringOrderScopeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl> AsAnyOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.AnyOrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.AnyOrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.AnyOrderQueryBuilderDsl.Of()),
                RecurringOrderScopeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl> AsApplicableRecurrencePolicies(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.ApplicableRecurrencePoliciesQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.ApplicableRecurrencePoliciesQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.ApplicableRecurrencePoliciesQueryBuilderDsl.Of()),
                RecurringOrderScopeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl> AsNonRecurringOrdersOnly(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.NonRecurringOrdersOnlyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.NonRecurringOrdersOnlyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.NonRecurringOrdersOnlyQueryBuilderDsl.Of()),
                RecurringOrderScopeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl> AsRecurringOrdersOnly(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrdersOnlyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrdersOnlyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrdersOnlyQueryBuilderDsl.Of()),
                RecurringOrderScopeQueryBuilderDsl.Of);
        }
    }
}
