using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class DeliveryQueryBuilderDsl
    {
        public DeliveryQueryBuilderDsl()
        {
        }

        public static DeliveryQueryBuilderDsl Of()
        {
            return new DeliveryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DeliveryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(p, DeliveryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DeliveryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(p, DeliveryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DeliveryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(p, DeliveryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                DeliveryQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DeliveryQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<DeliveryQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(p, DeliveryQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DeliveryQueryBuilderDsl> Parcels(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl.Of())),
                DeliveryQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DeliveryQueryBuilderDsl> Parcels()
        {
            return new CollectionPredicateBuilder<DeliveryQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcels")),
                    p => new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(p, DeliveryQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DeliveryQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                DeliveryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                DeliveryQueryBuilderDsl.Of);
        }


    }
}
