using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionSetMessagesActionQueryBuilderDsl
    {
        public SubscriptionSetMessagesActionQueryBuilderDsl()
        {
        }

        public static SubscriptionSetMessagesActionQueryBuilderDsl Of()
        {
            return new SubscriptionSetMessagesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionSetMessagesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<SubscriptionSetMessagesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<SubscriptionSetMessagesActionQueryBuilderDsl>(p, SubscriptionSetMessagesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionSetMessagesActionQueryBuilderDsl> Messages(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionSetMessagesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("messages"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.MessageSubscriptionQueryBuilderDsl.Of())),
                SubscriptionSetMessagesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionSetMessagesActionQueryBuilderDsl> Messages()
        {
            return new CollectionPredicateBuilder<SubscriptionSetMessagesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("messages")),
                    p => new CombinationQueryPredicate<SubscriptionSetMessagesActionQueryBuilderDsl>(p, SubscriptionSetMessagesActionQueryBuilderDsl.Of));
        }

    }
}
