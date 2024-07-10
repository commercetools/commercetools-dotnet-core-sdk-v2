using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetSupplyChannelActionQueryBuilderDsl
    {
        public InventoryEntrySetSupplyChannelActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetSupplyChannelActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetSupplyChannelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetSupplyChannelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetSupplyChannelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetSupplyChannelActionQueryBuilderDsl>(p, InventoryEntrySetSupplyChannelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntrySetSupplyChannelActionQueryBuilderDsl> SupplyChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntrySetSupplyChannelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                InventoryEntrySetSupplyChannelActionQueryBuilderDsl.Of);
        }


    }
}
