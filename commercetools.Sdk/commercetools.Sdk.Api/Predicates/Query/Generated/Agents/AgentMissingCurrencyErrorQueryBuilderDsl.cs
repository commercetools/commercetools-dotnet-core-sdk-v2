// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentMissingCurrencyErrorQueryBuilderDsl
    {
        public AgentMissingCurrencyErrorQueryBuilderDsl()
        {
        }

        public static AgentMissingCurrencyErrorQueryBuilderDsl Of()
        {
            return new AgentMissingCurrencyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentMissingCurrencyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentMissingCurrencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentMissingCurrencyErrorQueryBuilderDsl>(p, AgentMissingCurrencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentMissingCurrencyErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentMissingCurrencyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentMissingCurrencyErrorQueryBuilderDsl>(p, AgentMissingCurrencyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
