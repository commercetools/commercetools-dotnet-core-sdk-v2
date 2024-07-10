using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ParcelMeasurementsUpdatedMessageQueryBuilderDsl
    {
        public ParcelMeasurementsUpdatedMessageQueryBuilderDsl()
        {
        }

        public static ParcelMeasurementsUpdatedMessageQueryBuilderDsl Of()
        {
            return new ParcelMeasurementsUpdatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl> Measurements(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("measurements"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ParcelMeasurementsQueryBuilderDsl.Of())),
                ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<ParcelMeasurementsUpdatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<ParcelMeasurementsUpdatedMessageQueryBuilderDsl>(p, ParcelMeasurementsUpdatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
