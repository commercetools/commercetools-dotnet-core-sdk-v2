// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl
    {
        public GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl>(p, GraphQLAgentMissingShoppingListNameErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
