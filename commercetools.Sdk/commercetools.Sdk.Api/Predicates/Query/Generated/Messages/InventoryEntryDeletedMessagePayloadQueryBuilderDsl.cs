using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class InventoryEntryDeletedMessagePayloadQueryBuilderDsl
    {
        public InventoryEntryDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static InventoryEntryDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new InventoryEntryDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessagePayloadQueryBuilderDsl>(p, InventoryEntryDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryDeletedMessagePayloadQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<InventoryEntryDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<InventoryEntryDeletedMessagePayloadQueryBuilderDsl>(p, InventoryEntryDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryDeletedMessagePayloadQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                InventoryEntryDeletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
