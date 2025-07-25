using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl
    {
        public OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl>(p, OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl> Order(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("order"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl> RecurringOrderRef(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurringOrderRef"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurringOrders.RecurringOrderReferenceQueryBuilderDsl.Of())),
                OrderCreatedFromRecurringOrderMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
