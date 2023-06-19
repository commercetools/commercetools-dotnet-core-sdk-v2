using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionSetChangesActionQueryBuilderDsl
    {
        public SubscriptionSetChangesActionQueryBuilderDsl()
        {
        }

        public static SubscriptionSetChangesActionQueryBuilderDsl Of()
        {
            return new SubscriptionSetChangesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionSetChangesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<SubscriptionSetChangesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<SubscriptionSetChangesActionQueryBuilderDsl>(p, SubscriptionSetChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionSetChangesActionQueryBuilderDsl> Changes(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionSetChangesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("changes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.ChangeSubscriptionQueryBuilderDsl.Of())),
                SubscriptionSetChangesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionSetChangesActionQueryBuilderDsl> Changes()
        {
            return new CollectionPredicateBuilder<SubscriptionSetChangesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("changes")),
                    p => new CombinationQueryPredicate<SubscriptionSetChangesActionQueryBuilderDsl>(p, SubscriptionSetChangesActionQueryBuilderDsl.Of));
        }

    }
}
