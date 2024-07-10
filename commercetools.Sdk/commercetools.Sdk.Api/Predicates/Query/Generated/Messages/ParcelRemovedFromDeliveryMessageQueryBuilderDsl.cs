using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelRemovedFromDeliveryMessageQueryBuilderDsl
    {
        public ParcelRemovedFromDeliveryMessageQueryBuilderDsl()
        {
        }

        public static ParcelRemovedFromDeliveryMessageQueryBuilderDsl Of()
        {
            return new ParcelRemovedFromDeliveryMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl> Parcel(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parcel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelQueryBuilderDsl.Of())),
                ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelRemovedFromDeliveryMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelRemovedFromDeliveryMessageQueryBuilderDsl>(p, ParcelRemovedFromDeliveryMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
