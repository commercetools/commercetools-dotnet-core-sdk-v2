// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentNoLineItemsExtractedErrorQueryBuilderDsl
    {
        public AgentNoLineItemsExtractedErrorQueryBuilderDsl()
        {
        }

        public static AgentNoLineItemsExtractedErrorQueryBuilderDsl Of()
        {
            return new AgentNoLineItemsExtractedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentNoLineItemsExtractedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentNoLineItemsExtractedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentNoLineItemsExtractedErrorQueryBuilderDsl>(p, AgentNoLineItemsExtractedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentNoLineItemsExtractedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentNoLineItemsExtractedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentNoLineItemsExtractedErrorQueryBuilderDsl>(p, AgentNoLineItemsExtractedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
