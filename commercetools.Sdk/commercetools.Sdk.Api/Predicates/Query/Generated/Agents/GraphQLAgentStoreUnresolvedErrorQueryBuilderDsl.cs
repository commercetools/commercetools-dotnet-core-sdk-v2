// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl
    {
        public GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl>(p, GraphQLAgentStoreUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
