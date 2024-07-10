using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl
    {
        public StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl> AddedSupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedSupplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl> AddedSupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedSupplyChannels")),
                    p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl> RemovedSupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedSupplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl> RemovedSupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedSupplyChannels")),
                    p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
