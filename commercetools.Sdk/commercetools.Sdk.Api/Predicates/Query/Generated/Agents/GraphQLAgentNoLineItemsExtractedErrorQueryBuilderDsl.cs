// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl
    {
        public GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl>(p, GraphQLAgentNoLineItemsExtractedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
