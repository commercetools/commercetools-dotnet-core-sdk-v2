using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl
    {
        public InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>(p, InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long> OldQuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldQuantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>(p, InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long> NewQuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newQuantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>(p, InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long> OldAvailableQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldAvailableQuantity")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>(p, InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long> NewAvailableQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newAvailableQuantity")),
            p => new CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>(p, InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryQuantitySetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
