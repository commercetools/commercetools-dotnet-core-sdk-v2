using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class SyncInfoQueryBuilderDsl
    {
        public SyncInfoQueryBuilderDsl()
        {
        }

        public static SyncInfoQueryBuilderDsl Of()
        {
            return new SyncInfoQueryBuilderDsl();
        }

        public CombinationQueryPredicate<SyncInfoQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SyncInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelReferenceQueryBuilderDsl.Of())),
                SyncInfoQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<SyncInfoQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<SyncInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<SyncInfoQueryBuilderDsl>(p, SyncInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SyncInfoQueryBuilderDsl, DateTime> SyncedAt()
        {
            return new ComparisonPredicateBuilder<SyncInfoQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("syncedAt")),
            p => new CombinationQueryPredicate<SyncInfoQueryBuilderDsl>(p, SyncInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
