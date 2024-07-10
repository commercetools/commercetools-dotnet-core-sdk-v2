using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class DeliveryDraftQueryBuilderDsl
    {
        public DeliveryDraftQueryBuilderDsl()
        {
        }

        public static DeliveryDraftQueryBuilderDsl Of()
        {
            return new DeliveryDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DeliveryDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(p, DeliveryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                DeliveryDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DeliveryDraftQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<DeliveryDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(p, DeliveryDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl> Parcels(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelDraftQueryBuilderDsl.Of())),
                DeliveryDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DeliveryDraftQueryBuilderDsl> Parcels()
        {
            return new CollectionPredicateBuilder<DeliveryDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcels")),
                    p => new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(p, DeliveryDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressDraftQueryBuilderDsl.Of())),
                DeliveryDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                DeliveryDraftQueryBuilderDsl.Of);
        }


    }
}
