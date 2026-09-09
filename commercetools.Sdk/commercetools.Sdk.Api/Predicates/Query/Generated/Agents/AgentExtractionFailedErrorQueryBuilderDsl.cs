// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentExtractionFailedErrorQueryBuilderDsl
    {
        public AgentExtractionFailedErrorQueryBuilderDsl()
        {
        }

        public static AgentExtractionFailedErrorQueryBuilderDsl Of()
        {
            return new AgentExtractionFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentExtractionFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentExtractionFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentExtractionFailedErrorQueryBuilderDsl>(p, AgentExtractionFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentExtractionFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentExtractionFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentExtractionFailedErrorQueryBuilderDsl>(p, AgentExtractionFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
