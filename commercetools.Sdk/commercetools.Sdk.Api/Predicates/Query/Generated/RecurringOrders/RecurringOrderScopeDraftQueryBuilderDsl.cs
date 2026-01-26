using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderScopeDraftQueryBuilderDsl
    {
        public RecurringOrderScopeDraftQueryBuilderDsl()
        {
        }

        public static RecurringOrderScopeDraftQueryBuilderDsl Of()
        {
            return new RecurringOrderScopeDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderScopeDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderScopeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl>(p, RecurringOrderScopeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl> AsAnyOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.AnyOrderDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.AnyOrderDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.AnyOrderDraftQueryBuilderDsl.Of()),
                RecurringOrderScopeDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl> AsApplicableRecurrencePolicies(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.ApplicableRecurrencePoliciesDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.ApplicableRecurrencePoliciesDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.ApplicableRecurrencePoliciesDraftQueryBuilderDsl.Of()),
                RecurringOrderScopeDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl> AsNonRecurringOrdersOnly(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.NonRecurringOrdersOnlyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.NonRecurringOrdersOnlyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.NonRecurringOrdersOnlyDraftQueryBuilderDsl.Of()),
                RecurringOrderScopeDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl> AsRecurringOrdersOnly(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrdersOnlyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrdersOnlyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderScopeDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrdersOnlyDraftQueryBuilderDsl.Of()),
                RecurringOrderScopeDraftQueryBuilderDsl.Of);
        }
    }
}
