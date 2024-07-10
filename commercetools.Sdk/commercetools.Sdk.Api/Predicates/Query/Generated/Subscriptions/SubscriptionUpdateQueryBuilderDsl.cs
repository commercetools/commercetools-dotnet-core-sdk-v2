using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionUpdateQueryBuilderDsl
    {
        public SubscriptionUpdateQueryBuilderDsl()
        {
        }

        public static SubscriptionUpdateQueryBuilderDsl Of()
        {
            return new SubscriptionUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<SubscriptionUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<SubscriptionUpdateQueryBuilderDsl>(p, SubscriptionUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionUpdateActionQueryBuilderDsl.Of())),
                SubscriptionUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<SubscriptionUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<SubscriptionUpdateQueryBuilderDsl>(p, SubscriptionUpdateQueryBuilderDsl.Of));
        }

    }
}
