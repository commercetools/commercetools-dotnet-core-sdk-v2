using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl
    {
        public InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl>(p, InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl>(p, InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryOutOfStockMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
