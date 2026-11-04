// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentMissingCurrencyErrorQueryBuilderDsl
    {
        public GraphQLAgentMissingCurrencyErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentMissingCurrencyErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentMissingCurrencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentMissingCurrencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentMissingCurrencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentMissingCurrencyErrorQueryBuilderDsl>(p, GraphQLAgentMissingCurrencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
