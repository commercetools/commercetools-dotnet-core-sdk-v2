using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreDistributionChannelsChangedMessageQueryBuilderDsl
    {
        public StoreDistributionChannelsChangedMessageQueryBuilderDsl()
        {
        }

        public static StoreDistributionChannelsChangedMessageQueryBuilderDsl Of()
        {
            return new StoreDistributionChannelsChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl> AddedDistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addedDistributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl> AddedDistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedDistributionChannels")),
                    p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl> RemovedDistributionChannels(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedDistributionChannels"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl> RemovedDistributionChannels()
        {
            return new CollectionPredicateBuilder<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedDistributionChannels")),
                    p => new CombinationQueryPredicate<StoreDistributionChannelsChangedMessageQueryBuilderDsl>(p, StoreDistributionChannelsChangedMessageQueryBuilderDsl.Of));
        }

    }
}
