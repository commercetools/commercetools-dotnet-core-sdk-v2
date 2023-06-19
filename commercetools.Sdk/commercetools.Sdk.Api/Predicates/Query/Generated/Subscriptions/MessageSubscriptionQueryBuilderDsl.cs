// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class MessageSubscriptionQueryBuilderDsl
    {
        public MessageSubscriptionQueryBuilderDsl()
        {
        }

        public static MessageSubscriptionQueryBuilderDsl Of()
        {
            return new MessageSubscriptionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessageSubscriptionQueryBuilderDsl, string> ResourceTypeId()
        {
            return new ComparisonPredicateBuilder<MessageSubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceTypeId")),
            p => new CombinationQueryPredicate<MessageSubscriptionQueryBuilderDsl>(p, MessageSubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MessageSubscriptionQueryBuilderDsl, string> Types()
        {
            return new ComparableCollectionPredicateBuilder<MessageSubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("types")),
            p => new CombinationQueryPredicate<MessageSubscriptionQueryBuilderDsl>(p, MessageSubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
