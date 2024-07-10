using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderUpdateSyncInfoActionQueryBuilderDsl
    {
        public StagedOrderUpdateSyncInfoActionQueryBuilderDsl()
        {
        }

        public static StagedOrderUpdateSyncInfoActionQueryBuilderDsl Of()
        {
            return new StagedOrderUpdateSyncInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderUpdateSyncInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderUpdateSyncInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderUpdateSyncInfoActionQueryBuilderDsl>(p, StagedOrderUpdateSyncInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderUpdateSyncInfoActionQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<StagedOrderUpdateSyncInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<StagedOrderUpdateSyncInfoActionQueryBuilderDsl>(p, StagedOrderUpdateSyncInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderUpdateSyncInfoActionQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderUpdateSyncInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderUpdateSyncInfoActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderUpdateSyncInfoActionQueryBuilderDsl, DateTime> SyncedAt()
        {
            return new ComparisonPredicateBuilder<StagedOrderUpdateSyncInfoActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("syncedAt")),
            p => new CombinationQueryPredicate<StagedOrderUpdateSyncInfoActionQueryBuilderDsl>(p, StagedOrderUpdateSyncInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
