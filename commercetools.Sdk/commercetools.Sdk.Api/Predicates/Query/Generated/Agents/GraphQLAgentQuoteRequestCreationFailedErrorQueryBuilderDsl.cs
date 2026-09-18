// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl
    {
        public GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl>(p, GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string> CartId()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartId")),
            p => new CombinationQueryPredicate<GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl>(p, GraphQLAgentQuoteRequestCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
