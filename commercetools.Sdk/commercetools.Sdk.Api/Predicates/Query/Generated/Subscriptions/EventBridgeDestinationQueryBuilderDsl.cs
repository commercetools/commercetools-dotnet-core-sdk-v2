// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class EventBridgeDestinationQueryBuilderDsl
    {
        public EventBridgeDestinationQueryBuilderDsl()
        {
        }

        public static EventBridgeDestinationQueryBuilderDsl Of()
        {
            return new EventBridgeDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<EventBridgeDestinationQueryBuilderDsl>(p, EventBridgeDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string> Region()
        {
            return new ComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("region")),
            p => new CombinationQueryPredicate<EventBridgeDestinationQueryBuilderDsl>(p, EventBridgeDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string> AccountId()
        {
            return new ComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accountId")),
            p => new CombinationQueryPredicate<EventBridgeDestinationQueryBuilderDsl>(p, EventBridgeDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string> Source()
        {
            return new ComparisonPredicateBuilder<EventBridgeDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("source")),
            p => new CombinationQueryPredicate<EventBridgeDestinationQueryBuilderDsl>(p, EventBridgeDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
