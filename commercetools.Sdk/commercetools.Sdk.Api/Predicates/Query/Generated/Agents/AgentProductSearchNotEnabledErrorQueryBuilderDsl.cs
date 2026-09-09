// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentProductSearchNotEnabledErrorQueryBuilderDsl
    {
        public AgentProductSearchNotEnabledErrorQueryBuilderDsl()
        {
        }

        public static AgentProductSearchNotEnabledErrorQueryBuilderDsl Of()
        {
            return new AgentProductSearchNotEnabledErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentProductSearchNotEnabledErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentProductSearchNotEnabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentProductSearchNotEnabledErrorQueryBuilderDsl>(p, AgentProductSearchNotEnabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentProductSearchNotEnabledErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentProductSearchNotEnabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentProductSearchNotEnabledErrorQueryBuilderDsl>(p, AgentProductSearchNotEnabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
