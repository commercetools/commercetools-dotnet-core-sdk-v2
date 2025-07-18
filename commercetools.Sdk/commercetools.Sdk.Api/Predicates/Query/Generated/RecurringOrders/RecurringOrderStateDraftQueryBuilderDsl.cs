using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderStateDraftQueryBuilderDsl
    {
        public RecurringOrderStateDraftQueryBuilderDsl()
        {
        }

        public static RecurringOrderStateDraftQueryBuilderDsl Of()
        {
            return new RecurringOrderStateDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderStateDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderStateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl>(p, RecurringOrderStateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl> AsActive(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderActiveQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderActiveQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderActiveQueryBuilderDsl.Of()),
                RecurringOrderStateDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl> AsCanceled(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderCanceledQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderCanceledQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderCanceledQueryBuilderDsl.Of()),
                RecurringOrderStateDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl> AsExpired(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderExpiredQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderExpiredQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderExpiredQueryBuilderDsl.Of()),
                RecurringOrderStateDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl> AsPaused(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderPausedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderPausedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderStateDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderPausedQueryBuilderDsl.Of()),
                RecurringOrderStateDraftQueryBuilderDsl.Of);
        }
    }
}
