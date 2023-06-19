using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetSupplyChannelsActionQueryBuilderDsl
    {
        public StoreSetSupplyChannelsActionQueryBuilderDsl()
        {
        }

        public static StoreSetSupplyChannelsActionQueryBuilderDsl Of()
        {
            return new StoreSetSupplyChannelsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetSupplyChannelsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetSupplyChannelsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetSupplyChannelsActionQueryBuilderDsl>(p, StoreSetSupplyChannelsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSetSupplyChannelsActionQueryBuilderDsl> SupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSetSupplyChannelsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("supplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreSetSupplyChannelsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSetSupplyChannelsActionQueryBuilderDsl> SupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreSetSupplyChannelsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("supplyChannels")),
                    p => new CombinationQueryPredicate<StoreSetSupplyChannelsActionQueryBuilderDsl>(p, StoreSetSupplyChannelsActionQueryBuilderDsl.Of));
        }

    }
}
