// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentMissingCustomerEmailErrorQueryBuilderDsl
    {
        public AgentMissingCustomerEmailErrorQueryBuilderDsl()
        {
        }

        public static AgentMissingCustomerEmailErrorQueryBuilderDsl Of()
        {
            return new AgentMissingCustomerEmailErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentMissingCustomerEmailErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentMissingCustomerEmailErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentMissingCustomerEmailErrorQueryBuilderDsl>(p, AgentMissingCustomerEmailErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentMissingCustomerEmailErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentMissingCustomerEmailErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentMissingCustomerEmailErrorQueryBuilderDsl>(p, AgentMissingCustomerEmailErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
