using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelAddedToDeliveryMessageQueryBuilderDsl
    {
        public ParcelAddedToDeliveryMessageQueryBuilderDsl()
        {
        }

        public static ParcelAddedToDeliveryMessageQueryBuilderDsl Of()
        {
            return new ParcelAddedToDeliveryMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl> Delivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("delivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl> Parcel(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl.Of())),
                ParcelAddedToDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelAddedToDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelAddedToDeliveryMessageQueryBuilderDsl>(p, ParcelAddedToDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
