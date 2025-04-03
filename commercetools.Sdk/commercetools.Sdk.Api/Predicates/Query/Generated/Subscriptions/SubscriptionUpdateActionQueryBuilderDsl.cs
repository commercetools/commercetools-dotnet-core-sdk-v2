using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionUpdateActionQueryBuilderDsl
    {
        public SubscriptionUpdateActionQueryBuilderDsl()
        {
        }

        public static SubscriptionUpdateActionQueryBuilderDsl Of()
        {
            return new SubscriptionUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<SubscriptionUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl>(p, SubscriptionUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl> AsChangeDestination(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionChangeDestinationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionChangeDestinationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionChangeDestinationActionQueryBuilderDsl.Of()),
                SubscriptionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl> AsSetChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetChangesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetChangesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetChangesActionQueryBuilderDsl.Of()),
                SubscriptionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl> AsSetEvents(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetEventsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetEventsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetEventsActionQueryBuilderDsl.Of()),
                SubscriptionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetKeyActionQueryBuilderDsl.Of()),
                SubscriptionUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl> AsSetMessages(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetMessagesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetMessagesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionSetMessagesActionQueryBuilderDsl.Of()),
                SubscriptionUpdateActionQueryBuilderDsl.Of);
        }
    }
}
