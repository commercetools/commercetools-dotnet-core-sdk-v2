using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddDeliveryActionQueryBuilderDsl
    {
        public StagedOrderAddDeliveryActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddDeliveryActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(p, StagedOrderAddDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(p, StagedOrderAddDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(p, StagedOrderAddDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                StagedOrderAddDeliveryActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(p, StagedOrderAddDeliveryActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                StagedOrderAddDeliveryActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl> Parcels(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl.Of())),
                StagedOrderAddDeliveryActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl> Parcels()
        {
            return new CollectionPredicateBuilder<StagedOrderAddDeliveryActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcels")),
                    p => new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(p, StagedOrderAddDeliveryActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StagedOrderAddDeliveryActionQueryBuilderDsl.Of);
        }


    }
}
