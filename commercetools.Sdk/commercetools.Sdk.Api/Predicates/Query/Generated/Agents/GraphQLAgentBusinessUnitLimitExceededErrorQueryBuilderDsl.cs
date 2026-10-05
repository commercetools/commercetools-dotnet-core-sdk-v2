// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl
    {
        public GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl>(p, GraphQLAgentBusinessUnitLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
