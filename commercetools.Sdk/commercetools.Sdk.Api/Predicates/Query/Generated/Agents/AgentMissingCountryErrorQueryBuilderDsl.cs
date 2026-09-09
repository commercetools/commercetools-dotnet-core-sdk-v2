// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentMissingCountryErrorQueryBuilderDsl
    {
        public AgentMissingCountryErrorQueryBuilderDsl()
        {
        }

        public static AgentMissingCountryErrorQueryBuilderDsl Of()
        {
            return new AgentMissingCountryErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentMissingCountryErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentMissingCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentMissingCountryErrorQueryBuilderDsl>(p, AgentMissingCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentMissingCountryErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentMissingCountryErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentMissingCountryErrorQueryBuilderDsl>(p, AgentMissingCountryErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
