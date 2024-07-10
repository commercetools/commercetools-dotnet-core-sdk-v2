using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl
    {
        public StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl> AddedDistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedDistributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl> AddedDistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedDistributionChannels")),
                    p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl> RemovedDistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedDistributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl> RemovedDistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedDistributionChannels")),
                    p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
