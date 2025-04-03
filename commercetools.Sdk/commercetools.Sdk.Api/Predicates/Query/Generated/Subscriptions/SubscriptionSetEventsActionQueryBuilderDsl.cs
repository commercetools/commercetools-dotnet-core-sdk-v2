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
        public CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl> Messages(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.EventSubscriptionQueryBuilderDsl.Of())),
                SubscriptionSetEventsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionSetEventsActionQueryBuilderDsl> Messages()
        {
            return new CollectionPredicateBuilder<SubscriptionSetEventsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("messages")),
                    p => new CombinationQueryPredicate<SubscriptionSetEventsActionQueryBuilderDsl>(p, SubscriptionSetEventsActionQueryBuilderDsl.Of));
        }

    }
}
