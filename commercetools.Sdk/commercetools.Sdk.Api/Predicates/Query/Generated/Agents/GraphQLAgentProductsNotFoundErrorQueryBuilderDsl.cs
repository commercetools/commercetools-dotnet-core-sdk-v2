// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentProductsNotFoundErrorQueryBuilderDsl
    {
        public GraphQLAgentProductsNotFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentProductsNotFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentProductsNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentProductsNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentProductsNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentProductsNotFoundErrorQueryBuilderDsl>(p, GraphQLAgentProductsNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
