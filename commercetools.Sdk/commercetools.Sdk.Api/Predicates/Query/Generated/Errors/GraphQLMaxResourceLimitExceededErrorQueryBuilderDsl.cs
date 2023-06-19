// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl
    {
        public GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl Of()
        {
            return new GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl>(p, GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl, string> ExceededResource()
        {
            return new ComparisonPredicateBuilder<GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("exceededResource")),
            p => new CombinationQueryPredicate<GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl>(p, GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
