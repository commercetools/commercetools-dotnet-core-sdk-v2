// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class SubscriptionSetKeyActionQueryBuilderDsl
    {
        public SubscriptionSetKeyActionQueryBuilderDsl()
        {
        }

        public static SubscriptionSetKeyActionQueryBuilderDsl Of()
        {
            return new SubscriptionSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SubscriptionSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<SubscriptionSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<SubscriptionSetKeyActionQueryBuilderDsl>(p, SubscriptionSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SubscriptionSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<SubscriptionSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<SubscriptionSetKeyActionQueryBuilderDsl>(p, SubscriptionSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
