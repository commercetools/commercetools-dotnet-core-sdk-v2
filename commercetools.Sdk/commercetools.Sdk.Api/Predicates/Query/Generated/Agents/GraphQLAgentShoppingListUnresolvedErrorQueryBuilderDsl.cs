// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl
    {
        public GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl>(p, GraphQLAgentShoppingListUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
