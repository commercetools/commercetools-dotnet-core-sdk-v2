// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl
    {
        public GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl Of()
        {
            return new GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl>(p, GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
