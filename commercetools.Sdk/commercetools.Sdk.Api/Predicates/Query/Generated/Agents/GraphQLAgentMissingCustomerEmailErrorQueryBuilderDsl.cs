// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl
    {
        public GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl>(p, GraphQLAgentMissingCustomerEmailErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
