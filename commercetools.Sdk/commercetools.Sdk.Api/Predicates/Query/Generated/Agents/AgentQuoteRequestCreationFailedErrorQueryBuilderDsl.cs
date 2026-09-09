// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentQuoteRequestCreationFailedErrorQueryBuilderDsl
    {
        public AgentQuoteRequestCreationFailedErrorQueryBuilderDsl()
        {
        }

        public static AgentQuoteRequestCreationFailedErrorQueryBuilderDsl Of()
        {
            return new AgentQuoteRequestCreationFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl>(p, AgentQuoteRequestCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl>(p, AgentQuoteRequestCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string> CartId()
        {
            return new ComparisonPredicateBuilder<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartId")),
            p => new CombinationQueryPredicate<AgentQuoteRequestCreationFailedErrorQueryBuilderDsl>(p, AgentQuoteRequestCreationFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
