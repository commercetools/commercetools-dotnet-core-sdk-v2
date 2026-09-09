// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentMissingEntityTypeErrorQueryBuilderDsl
    {
        public AgentMissingEntityTypeErrorQueryBuilderDsl()
        {
        }

        public static AgentMissingEntityTypeErrorQueryBuilderDsl Of()
        {
            return new AgentMissingEntityTypeErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentMissingEntityTypeErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentMissingEntityTypeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentMissingEntityTypeErrorQueryBuilderDsl>(p, AgentMissingEntityTypeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentMissingEntityTypeErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentMissingEntityTypeErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentMissingEntityTypeErrorQueryBuilderDsl>(p, AgentMissingEntityTypeErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
