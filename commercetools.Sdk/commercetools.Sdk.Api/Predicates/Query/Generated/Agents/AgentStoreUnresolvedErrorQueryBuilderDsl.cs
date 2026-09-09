// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentStoreUnresolvedErrorQueryBuilderDsl
    {
        public AgentStoreUnresolvedErrorQueryBuilderDsl()
        {
        }

        public static AgentStoreUnresolvedErrorQueryBuilderDsl Of()
        {
            return new AgentStoreUnresolvedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentStoreUnresolvedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentStoreUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentStoreUnresolvedErrorQueryBuilderDsl>(p, AgentStoreUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentStoreUnresolvedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentStoreUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentStoreUnresolvedErrorQueryBuilderDsl>(p, AgentStoreUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
