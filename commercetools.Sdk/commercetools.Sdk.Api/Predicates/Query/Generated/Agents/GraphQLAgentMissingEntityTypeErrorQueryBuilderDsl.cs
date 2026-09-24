// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl
    {
        public GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl>(p, GraphQLAgentMissingEntityTypeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
