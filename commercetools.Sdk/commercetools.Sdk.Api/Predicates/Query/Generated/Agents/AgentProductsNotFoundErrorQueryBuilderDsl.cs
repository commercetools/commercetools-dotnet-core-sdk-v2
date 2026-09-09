// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentProductsNotFoundErrorQueryBuilderDsl
    {
        public AgentProductsNotFoundErrorQueryBuilderDsl()
        {
        }

        public static AgentProductsNotFoundErrorQueryBuilderDsl Of()
        {
            return new AgentProductsNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentProductsNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentProductsNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentProductsNotFoundErrorQueryBuilderDsl>(p, AgentProductsNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentProductsNotFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentProductsNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentProductsNotFoundErrorQueryBuilderDsl>(p, AgentProductsNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
