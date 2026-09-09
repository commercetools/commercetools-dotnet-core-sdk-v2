// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentOutOfScopeErrorQueryBuilderDsl
    {
        public AgentOutOfScopeErrorQueryBuilderDsl()
        {
        }

        public static AgentOutOfScopeErrorQueryBuilderDsl Of()
        {
            return new AgentOutOfScopeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentOutOfScopeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentOutOfScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentOutOfScopeErrorQueryBuilderDsl>(p, AgentOutOfScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentOutOfScopeErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentOutOfScopeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentOutOfScopeErrorQueryBuilderDsl>(p, AgentOutOfScopeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
