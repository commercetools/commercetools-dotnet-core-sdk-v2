using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl
    {
        public InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl>(p, InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl>(p, InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl, long> QuantityOnStock()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantityOnStock")),
            p => new CombinationQueryPredicate<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl>(p, InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntrySafetyStockMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
