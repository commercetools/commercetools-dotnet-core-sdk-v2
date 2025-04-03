// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class EventSubscriptionQueryBuilderDsl
    {
        public EventSubscriptionQueryBuilderDsl()
        {
        }

        public static EventSubscriptionQueryBuilderDsl Of()
        {
            return new EventSubscriptionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EventSubscriptionQueryBuilderDsl, string> ResourceTypeId()
        {
            return new ComparisonPredicateBuilder<EventSubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceTypeId")),
            p => new CombinationQueryPredicate<EventSubscriptionQueryBuilderDsl>(p, EventSubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<EventSubscriptionQueryBuilderDsl, string> Types()
        {
            return new ComparableCollectionPredicateBuilder<EventSubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("types")),
            p => new CombinationQueryPredicate<EventSubscriptionQueryBuilderDsl>(p, EventSubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
