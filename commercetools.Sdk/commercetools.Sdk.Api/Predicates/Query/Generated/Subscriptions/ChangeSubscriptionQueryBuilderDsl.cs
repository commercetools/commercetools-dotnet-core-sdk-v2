// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Subscriptions
{

    public partial class ChangeSubscriptionQueryBuilderDsl
    {
        public ChangeSubscriptionQueryBuilderDsl()
        {
        }

        public static ChangeSubscriptionQueryBuilderDsl Of()
        {
            return new ChangeSubscriptionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ChangeSubscriptionQueryBuilderDsl, string> ResourceTypeId()
        {
            return new ComparisonPredicateBuilder<ChangeSubscriptionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceTypeId")),
            p => new CombinationQueryPredicate<ChangeSubscriptionQueryBuilderDsl>(p, ChangeSubscriptionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
