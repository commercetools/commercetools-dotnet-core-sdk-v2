// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentFeatureDisabledErrorQueryBuilderDsl
    {
        public GraphQLAgentFeatureDisabledErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentFeatureDisabledErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentFeatureDisabledErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentFeatureDisabledErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentFeatureDisabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentFeatureDisabledErrorQueryBuilderDsl>(p, GraphQLAgentFeatureDisabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
