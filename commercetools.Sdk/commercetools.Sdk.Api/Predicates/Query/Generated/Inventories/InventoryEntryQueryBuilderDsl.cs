using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryQueryBuilderDsl
    {
        public InventoryEntryQueryBuilderDsl()
        {
        }

        public static InventoryEntryQueryBuilderDsl Of()
        {
            return new InventoryEntryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                InventoryEntryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<InventoryEntryQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                InventoryEntryQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long> QuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long> AvailableQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("availableQuantity")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long> RestockableInDays()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("restockableInDays")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, DateTime> ExpectedDelivery()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expectedDelivery")),
            p => new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(p, InventoryEntryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                InventoryEntryQueryBuilderDsl.Of);
        }


    }
}
