using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetParcelItemsActionQueryBuilderDsl
    {
        public OrderSetParcelItemsActionQueryBuilderDsl()
        {
        }

        public static OrderSetParcelItemsActionQueryBuilderDsl Of()
        {
            return new OrderSetParcelItemsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetParcelItemsActionQueryBuilderDsl>(p, OrderSetParcelItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<OrderSetParcelItemsActionQueryBuilderDsl>(p, OrderSetParcelItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<OrderSetParcelItemsActionQueryBuilderDsl>(p, OrderSetParcelItemsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetParcelItemsActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetParcelItemsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                OrderSetParcelItemsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<OrderSetParcelItemsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<OrderSetParcelItemsActionQueryBuilderDsl>(p, OrderSetParcelItemsActionQueryBuilderDsl.Of));
        }

    }
}
