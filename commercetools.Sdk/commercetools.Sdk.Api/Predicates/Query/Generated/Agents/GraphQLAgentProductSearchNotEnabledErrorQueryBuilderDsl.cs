// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl
    {
        public GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl>(p, GraphQLAgentProductSearchNotEnabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
