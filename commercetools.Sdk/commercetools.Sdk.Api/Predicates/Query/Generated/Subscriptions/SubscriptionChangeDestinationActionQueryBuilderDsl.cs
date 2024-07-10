using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionChangeDestinationActionQueryBuilderDsl
    {
        public SubscriptionChangeDestinationActionQueryBuilderDsl()
        {
        }

        public static SubscriptionChangeDestinationActionQueryBuilderDsl Of()
        {
            return new SubscriptionChangeDestinationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionChangeDestinationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<SubscriptionChangeDestinationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<SubscriptionChangeDestinationActionQueryBuilderDsl>(p, SubscriptionChangeDestinationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionChangeDestinationActionQueryBuilderDsl> Destination(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionChangeDestinationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("destination"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.DestinationQueryBuilderDsl.Of())),
                SubscriptionChangeDestinationActionQueryBuilderDsl.Of);
        }


    }
}
