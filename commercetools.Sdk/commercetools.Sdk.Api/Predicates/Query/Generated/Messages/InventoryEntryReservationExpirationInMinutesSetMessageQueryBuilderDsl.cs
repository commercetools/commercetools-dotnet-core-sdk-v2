using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl
    {
        public InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl()
        {
        }

        public static InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl Of()
        {
            return new InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long> NewReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newReservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long> OldReservationExpirationInMinutes()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldReservationExpirationInMinutes")),
            p => new CombinationQueryPredicate<InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl>(p, InventoryEntryReservationExpirationInMinutesSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
