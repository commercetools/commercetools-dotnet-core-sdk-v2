using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl
    {
        public DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl Of()
        {
            return new DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(p, DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(p, DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(p, DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl> OldItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl> OldItems()
        {
            return new CollectionPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldItems")),
                    p => new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(p, DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl>(p, DeliveryItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
