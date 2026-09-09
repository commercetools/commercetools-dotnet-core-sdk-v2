// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentFeatureDisabledErrorQueryBuilderDsl
    {
        public AgentFeatureDisabledErrorQueryBuilderDsl()
        {
        }

        public static AgentFeatureDisabledErrorQueryBuilderDsl Of()
        {
            return new AgentFeatureDisabledErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentFeatureDisabledErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentFeatureDisabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentFeatureDisabledErrorQueryBuilderDsl>(p, AgentFeatureDisabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentFeatureDisabledErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentFeatureDisabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentFeatureDisabledErrorQueryBuilderDsl>(p, AgentFeatureDisabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
