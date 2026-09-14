// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl
    {
        public GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl>(p, GraphQLAgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
