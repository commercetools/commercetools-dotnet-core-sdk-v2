using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelItemsUpdatedMessagePayloadQueryBuilderDsl
    {
        public ParcelItemsUpdatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ParcelItemsUpdatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ParcelItemsUpdatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl> OldItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl> OldItems()
        {
            return new CollectionPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldItems")),
                    p => new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelItemsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
