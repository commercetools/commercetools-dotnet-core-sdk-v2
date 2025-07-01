using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionSetEventsActionQueryBuilderDsl
    {
        public SubscriptionSetEventsActionQueryBuilderDsl()
        {
        }

        public static SubscriptionSetEventsActionQueryBuilderDsl Of()
        {
            return new SubscriptionSetEventsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionSetEventsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<SubscriptionSetEventsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl>(p, SubscriptionSetEventsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl> Events(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("events"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventSubscriptionQueryBuilderDsl.Of())),
                SubscriptionSetEventsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionSetEventsActionQueryBuilderDsl> Events()
        {
            return new CollectionPredicateBuilder<SubscriptionSetEventsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("events")),
                    p => new CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl>(p, SubscriptionSetEventsActionQueryBuilderDsl.Of));
        }

    }
}
