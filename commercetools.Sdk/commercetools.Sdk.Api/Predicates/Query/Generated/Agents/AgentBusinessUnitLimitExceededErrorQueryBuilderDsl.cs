// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentBusinessUnitLimitExceededErrorQueryBuilderDsl
    {
        public AgentBusinessUnitLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static AgentBusinessUnitLimitExceededErrorQueryBuilderDsl Of()
        {
            return new AgentBusinessUnitLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentBusinessUnitLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentBusinessUnitLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentBusinessUnitLimitExceededErrorQueryBuilderDsl>(p, AgentBusinessUnitLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentBusinessUnitLimitExceededErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentBusinessUnitLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentBusinessUnitLimitExceededErrorQueryBuilderDsl>(p, AgentBusinessUnitLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
