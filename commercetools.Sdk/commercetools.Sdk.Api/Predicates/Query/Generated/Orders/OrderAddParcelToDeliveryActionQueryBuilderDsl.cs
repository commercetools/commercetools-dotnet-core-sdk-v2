using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderAddParcelToDeliveryActionQueryBuilderDsl
    {
        public OrderAddParcelToDeliveryActionQueryBuilderDsl()
        {
        }

        public static OrderAddParcelToDeliveryActionQueryBuilderDsl Of()
        {
            return new OrderAddParcelToDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(p, OrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(p, OrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(p, OrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(p, OrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                OrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                OrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                OrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<OrderAddParcelToDeliveryActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<OrderAddParcelToDeliveryActionQueryBuilderDsl>(p, OrderAddParcelToDeliveryActionQueryBuilderDsl.Of));
        }

    }
}
