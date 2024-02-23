using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelTrackingDataUpdatedMessageQueryBuilderDsl
    {
        public ParcelTrackingDataUpdatedMessageQueryBuilderDsl()
        {
        }

        public static ParcelTrackingDataUpdatedMessageQueryBuilderDsl Of()
        {
            return new ParcelTrackingDataUpdatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl> TrackingData(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("trackingData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.TrackingDataQueryBuilderDsl.Of())),
                ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelTrackingDataUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelTrackingDataUpdatedMessageQueryBuilderDsl>(p, ParcelTrackingDataUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
