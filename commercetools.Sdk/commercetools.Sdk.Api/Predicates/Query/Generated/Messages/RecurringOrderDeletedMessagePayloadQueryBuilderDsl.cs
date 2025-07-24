using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class RecurringOrderDeletedMessagePayloadQueryBuilderDsl
    {
        public RecurringOrderDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static RecurringOrderDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new RecurringOrderDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderDeletedMessagePayloadQueryBuilderDsl>(p, RecurringOrderDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurringOrderDeletedMessagePayloadQueryBuilderDsl> RecurringOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurringOrderDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringOrder"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderQueryBuilderDsl.Of())),
                RecurringOrderDeletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
