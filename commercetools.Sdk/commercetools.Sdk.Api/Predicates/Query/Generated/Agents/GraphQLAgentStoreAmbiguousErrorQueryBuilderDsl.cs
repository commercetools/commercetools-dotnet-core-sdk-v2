// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl
    {
        public GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl>(p, GraphQLAgentStoreAmbiguousErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
