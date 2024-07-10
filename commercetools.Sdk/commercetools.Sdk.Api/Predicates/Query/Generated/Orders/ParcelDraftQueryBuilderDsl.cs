using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ParcelDraftQueryBuilderDsl
    {
        public ParcelDraftQueryBuilderDsl()
        {
        }

        public static ParcelDraftQueryBuilderDsl Of()
        {
            return new ParcelDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ParcelDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ParcelDraftQueryBuilderDsl>(p, ParcelDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelDraftQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                ParcelDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelDraftQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                ParcelDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelDraftQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                ParcelDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ParcelDraftQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<ParcelDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<ParcelDraftQueryBuilderDsl>(p, ParcelDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ParcelDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ParcelDraftQueryBuilderDsl.Of);
        }


    }
}
