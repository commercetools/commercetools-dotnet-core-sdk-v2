// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentStoreAmbiguousErrorQueryBuilderDsl
    {
        public AgentStoreAmbiguousErrorQueryBuilderDsl()
        {
        }

        public static AgentStoreAmbiguousErrorQueryBuilderDsl Of()
        {
            return new AgentStoreAmbiguousErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentStoreAmbiguousErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentStoreAmbiguousErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentStoreAmbiguousErrorQueryBuilderDsl>(p, AgentStoreAmbiguousErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentStoreAmbiguousErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentStoreAmbiguousErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentStoreAmbiguousErrorQueryBuilderDsl>(p, AgentStoreAmbiguousErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
