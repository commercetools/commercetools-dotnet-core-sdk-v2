using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryQuantitySetMessageQueryBuilderDsl
    {
        public InventoryEntryQuantitySetMessageQueryBuilderDsl()
        {
        }

        public static InventoryEntryQuantitySetMessageQueryBuilderDsl Of()
        {
            return new InventoryEntryQuantitySetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                InventoryEntryQuantitySetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                InventoryEntryQuantitySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                InventoryEntryQuantitySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                InventoryEntryQuantitySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> OldQuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldQuantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> NewQuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newQuantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> OldAvailableQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldAvailableQuantity")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long> NewAvailableQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newAvailableQuantity")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(p, InventoryEntryQuantitySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQuantitySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryQuantitySetMessageQueryBuilderDsl.Of);
        }


    }
}
