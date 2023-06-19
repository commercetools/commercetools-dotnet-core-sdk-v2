using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl
    {
        public ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
