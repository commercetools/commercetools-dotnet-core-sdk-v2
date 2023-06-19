using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelItemsUpdatedMessageQueryBuilderDsl
    {
        public ParcelItemsUpdatedMessageQueryBuilderDsl()
        {
        }

        public static ParcelItemsUpdatedMessageQueryBuilderDsl Of()
        {
            return new ParcelItemsUpdatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl> OldItems(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryItemQueryBuilderDsl.Of())),
                ParcelItemsUpdatedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl> OldItems()
        {
            return new CollectionPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldItems")),
                    p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelItemsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelItemsUpdatedMessageQueryBuilderDsl>(p, ParcelItemsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
