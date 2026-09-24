// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentOutOfScopeErrorQueryBuilderDsl
    {
        public GraphQLAgentOutOfScopeErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentOutOfScopeErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentOutOfScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentOutOfScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentOutOfScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentOutOfScopeErrorQueryBuilderDsl>(p, GraphQLAgentOutOfScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
