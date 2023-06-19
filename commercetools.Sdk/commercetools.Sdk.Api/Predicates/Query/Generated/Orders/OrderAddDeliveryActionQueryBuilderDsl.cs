using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderAddDeliveryActionQueryBuilderDsl
    {
        public OrderAddDeliveryActionQueryBuilderDsl()
        {
        }

        public static OrderAddDeliveryActionQueryBuilderDsl Of()
        {
            return new OrderAddDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(p, OrderAddDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(p, OrderAddDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                OrderAddDeliveryActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(p, OrderAddDeliveryActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(p, OrderAddDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderAddDeliveryActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl> Parcels(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl.Of())),
                OrderAddDeliveryActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl> Parcels()
        {
            return new CollectionPredicateBuilder<OrderAddDeliveryActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcels")),
                    p => new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(p, OrderAddDeliveryActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                OrderAddDeliveryActionQueryBuilderDsl.Of);
        }


    }
}
