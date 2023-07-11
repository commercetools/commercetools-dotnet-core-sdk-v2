using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderUpdateSyncInfoActionQueryBuilderDsl
    {
        public OrderUpdateSyncInfoActionQueryBuilderDsl()
        {
        }

        public static OrderUpdateSyncInfoActionQueryBuilderDsl Of()
        {
            return new OrderUpdateSyncInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderUpdateSyncInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderUpdateSyncInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderUpdateSyncInfoActionQueryBuilderDsl>(p, OrderUpdateSyncInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderUpdateSyncInfoActionQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<OrderUpdateSyncInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<OrderUpdateSyncInfoActionQueryBuilderDsl>(p, OrderUpdateSyncInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderUpdateSyncInfoActionQueryBuilderDsl> Channel(
            Func<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderUpdateSyncInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("channel"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Channels.ChannelResourceIdentifierQueryBuilderDsl.Of())),
                OrderUpdateSyncInfoActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderUpdateSyncInfoActionQueryBuilderDsl, DateTime> SyncedAt()
        {
            return new ComparisonPredicateBuilder<OrderUpdateSyncInfoActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("syncedAt")),
            p => new CombinationQueryPredicate<OrderUpdateSyncInfoActionQueryBuilderDsl>(p, OrderUpdateSyncInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
