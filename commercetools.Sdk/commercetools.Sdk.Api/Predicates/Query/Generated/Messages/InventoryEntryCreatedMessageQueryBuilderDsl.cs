using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryCreatedMessageQueryBuilderDsl
    {
        public InventoryEntryCreatedMessageQueryBuilderDsl()
        {
        }

        public static InventoryEntryCreatedMessageQueryBuilderDsl Of()
        {
            return new InventoryEntryCreatedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                InventoryEntryCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                InventoryEntryCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                InventoryEntryCreatedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryCreatedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(p, InventoryEntryCreatedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                InventoryEntryCreatedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl> InventoryEntry(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryCreatedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inventoryEntry"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl.Of())),
                InventoryEntryCreatedMessageQueryBuilderDsl.Of);
        }


    }
}
