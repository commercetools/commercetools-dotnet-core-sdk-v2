// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentMissingCountryErrorQueryBuilderDsl
    {
        public GraphQLAgentMissingCountryErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentMissingCountryErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentMissingCountryErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentMissingCountryErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentMissingCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentMissingCountryErrorQueryBuilderDsl>(p, GraphQLAgentMissingCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
