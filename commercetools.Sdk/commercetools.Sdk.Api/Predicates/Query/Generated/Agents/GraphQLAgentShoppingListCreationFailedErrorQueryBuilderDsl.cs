// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl
    {
        public GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl>(p, GraphQLAgentShoppingListCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
