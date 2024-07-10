using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreSupplyChannelsChangedMessageQueryBuilderDsl
    {
        public StoreSupplyChannelsChangedMessageQueryBuilderDsl()
        {
        }

        public static StoreSupplyChannelsChangedMessageQueryBuilderDsl Of()
        {
            return new StoreSupplyChannelsChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl> AddedSupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedSupplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl> AddedSupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedSupplyChannels")),
                    p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl> RemovedSupplyChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedSupplyChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl> RemovedSupplyChannels()
        {
            return new CollectionPredicateBuilder<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedSupplyChannels")),
                    p => new CombinationQueryPredicate<StoreSupplyChannelsChangedMessageQueryBuilderDsl>(p, StoreSupplyChannelsChangedMessageQueryBuilderDsl.Of));
        }

    }
}
