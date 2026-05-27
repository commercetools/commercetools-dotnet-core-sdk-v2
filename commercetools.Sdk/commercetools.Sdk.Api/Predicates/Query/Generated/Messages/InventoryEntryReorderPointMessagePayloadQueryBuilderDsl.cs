using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryReorderPointMessagePayloadQueryBuilderDsl
    {
        public InventoryEntryReorderPointMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntryReorderPointMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntryReorderPointMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl>(p, InventoryEntryReorderPointMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl>(p, InventoryEntryReorderPointMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl, long> QuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl>(p, InventoryEntryReorderPointMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryReorderPointMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryReorderPointMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
