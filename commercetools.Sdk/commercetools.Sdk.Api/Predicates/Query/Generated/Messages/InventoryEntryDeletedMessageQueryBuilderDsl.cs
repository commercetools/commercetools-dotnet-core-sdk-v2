using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryDeletedMessageQueryBuilderDsl
    {
        public InventoryEntryDeletedMessageQueryBuilderDsl()
        {
        }

        public static InventoryEntryDeletedMessageQueryBuilderDsl Of()
        {
            return new InventoryEntryDeletedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                InventoryEntryDeletedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                InventoryEntryDeletedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                InventoryEntryDeletedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                InventoryEntryDeletedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(p, InventoryEntryDeletedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDeletedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryDeletedMessageQueryBuilderDsl.Of);
        }


    }
}
