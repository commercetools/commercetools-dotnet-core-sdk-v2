using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl
    {
        public ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
