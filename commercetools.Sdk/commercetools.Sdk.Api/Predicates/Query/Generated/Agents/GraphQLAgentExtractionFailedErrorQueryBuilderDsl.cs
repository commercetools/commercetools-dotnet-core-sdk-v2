// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentExtractionFailedErrorQueryBuilderDsl
    {
        public GraphQLAgentExtractionFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentExtractionFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentExtractionFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentExtractionFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentExtractionFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentExtractionFailedErrorQueryBuilderDsl>(p, GraphQLAgentExtractionFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
