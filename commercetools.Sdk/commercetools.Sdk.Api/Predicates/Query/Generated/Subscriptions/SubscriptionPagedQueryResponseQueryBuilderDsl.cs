using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionPagedQueryResponseQueryBuilderDsl
    {
        public SubscriptionPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static SubscriptionPagedQueryResponseQueryBuilderDsl Of()
        {
            return new SubscriptionPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl>(p, SubscriptionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl>(p, SubscriptionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl>(p, SubscriptionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl>(p, SubscriptionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Subscriptions.SubscriptionQueryBuilderDsl.Of())),
                SubscriptionPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<SubscriptionPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<SubscriptionPagedQueryResponseQueryBuilderDsl>(p, SubscriptionPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
