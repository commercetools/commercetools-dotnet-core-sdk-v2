// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl
    {
        public AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl()
        {
        }

        public static AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl Of()
        {
            return new AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl>(p, AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl>(p, AgentStoreDistributionChannelsUnsupportedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
