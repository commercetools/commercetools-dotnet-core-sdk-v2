using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetDistributionChannelsActionQueryBuilderDsl
    {
        public StoreSetDistributionChannelsActionQueryBuilderDsl()
        {
        }

        public static StoreSetDistributionChannelsActionQueryBuilderDsl Of()
        {
            return new StoreSetDistributionChannelsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetDistributionChannelsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetDistributionChannelsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetDistributionChannelsActionQueryBuilderDsl>(p, StoreSetDistributionChannelsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSetDistributionChannelsActionQueryBuilderDsl> DistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSetDistributionChannelsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("distributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StoreSetDistributionChannelsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSetDistributionChannelsActionQueryBuilderDsl> DistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreSetDistributionChannelsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("distributionChannels")),
                    p => new CombinationQueryPredicate<StoreSetDistributionChannelsActionQueryBuilderDsl>(p, StoreSetDistributionChannelsActionQueryBuilderDsl.Of));
        }

    }
}
