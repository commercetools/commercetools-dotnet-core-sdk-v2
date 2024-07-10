using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl
    {
        public ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl()
        {
        }

        public static ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl Of()
        {
            return new ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl> Parcel(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl.Of())),
                ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
