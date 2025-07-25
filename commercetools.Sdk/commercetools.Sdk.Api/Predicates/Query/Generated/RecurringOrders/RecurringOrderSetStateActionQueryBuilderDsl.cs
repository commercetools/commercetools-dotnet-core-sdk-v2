using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderSetStateActionQueryBuilderDsl
    {
        public RecurringOrderSetStateActionQueryBuilderDsl()
        {
        }

        public static RecurringOrderSetStateActionQueryBuilderDsl Of()
        {
            return new RecurringOrderSetStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderSetStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<RecurringOrderSetStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<RecurringOrderSetStateActionQueryBuilderDsl>(p, RecurringOrderSetStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderSetStateActionQueryBuilderDsl> RecurringOrderState(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderStateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderStateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderSetStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringOrderState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderStateDraftQueryBuilderDsl.Of())),
                RecurringOrderSetStateActionQueryBuilderDsl.Of);
        }


    }
}
