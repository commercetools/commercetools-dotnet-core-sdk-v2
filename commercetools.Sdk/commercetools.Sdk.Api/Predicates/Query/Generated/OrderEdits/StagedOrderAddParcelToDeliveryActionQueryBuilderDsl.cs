using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddParcelToDeliveryActionQueryBuilderDsl
    {
        public StagedOrderAddParcelToDeliveryActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddParcelToDeliveryActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddParcelToDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(p, StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(p, StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(p, StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(p, StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(p, StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddParcelToDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StagedOrderAddParcelToDeliveryActionQueryBuilderDsl.Of);
        }


    }
}
