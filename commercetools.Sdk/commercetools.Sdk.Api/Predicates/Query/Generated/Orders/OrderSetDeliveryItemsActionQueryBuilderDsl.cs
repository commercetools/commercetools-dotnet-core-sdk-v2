using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetDeliveryItemsActionQueryBuilderDsl
    {
        public OrderSetDeliveryItemsActionQueryBuilderDsl()
        {
        }

        public static OrderSetDeliveryItemsActionQueryBuilderDsl Of()
        {
            return new OrderSetDeliveryItemsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetDeliveryItemsActionQueryBuilderDsl>(p, OrderSetDeliveryItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderSetDeliveryItemsActionQueryBuilderDsl>(p, OrderSetDeliveryItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderSetDeliveryItemsActionQueryBuilderDsl>(p, OrderSetDeliveryItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetDeliveryItemsActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetDeliveryItemsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                OrderSetDeliveryItemsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<OrderSetDeliveryItemsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<OrderSetDeliveryItemsActionQueryBuilderDsl>(p, OrderSetDeliveryItemsActionQueryBuilderDsl.Of));
        }

    }
}
