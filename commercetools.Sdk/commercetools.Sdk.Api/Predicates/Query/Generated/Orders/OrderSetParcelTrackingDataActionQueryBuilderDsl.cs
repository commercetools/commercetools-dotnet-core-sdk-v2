using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetParcelTrackingDataActionQueryBuilderDsl
    {
        public OrderSetParcelTrackingDataActionQueryBuilderDsl()
        {
        }

        public static OrderSetParcelTrackingDataActionQueryBuilderDsl Of()
        {
            return new OrderSetParcelTrackingDataActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetParcelTrackingDataActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelTrackingDataActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetParcelTrackingDataActionQueryBuilderDsl>(p, OrderSetParcelTrackingDataActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelTrackingDataActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelTrackingDataActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<OrderSetParcelTrackingDataActionQueryBuilderDsl>(p, OrderSetParcelTrackingDataActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelTrackingDataActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelTrackingDataActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<OrderSetParcelTrackingDataActionQueryBuilderDsl>(p, OrderSetParcelTrackingDataActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetParcelTrackingDataActionQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetParcelTrackingDataActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                OrderSetParcelTrackingDataActionQueryBuilderDsl.Of);
        }


    }
}
