using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetParcelTrackingDataActionQueryBuilderDsl
    {
        public StagedOrderSetParcelTrackingDataActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetParcelTrackingDataActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetParcelTrackingDataActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl>(p, StagedOrderSetParcelTrackingDataActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl>(p, StagedOrderSetParcelTrackingDataActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl>(p, StagedOrderSetParcelTrackingDataActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetParcelTrackingDataActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                StagedOrderSetParcelTrackingDataActionQueryBuilderDsl.Of);
        }


    }
}
