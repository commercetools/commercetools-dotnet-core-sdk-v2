using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl
    {
        public ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl()
        {
        }

        public static ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl Of()
        {
            return new ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl>(p, ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl> Delivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("delivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl> Parcel(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl>(p, ParcelAddedToDeliveryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
