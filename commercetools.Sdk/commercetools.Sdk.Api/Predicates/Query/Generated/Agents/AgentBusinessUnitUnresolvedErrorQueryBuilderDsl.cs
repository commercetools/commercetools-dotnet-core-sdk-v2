// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentBusinessUnitUnresolvedErrorQueryBuilderDsl
    {
        public AgentBusinessUnitUnresolvedErrorQueryBuilderDsl()
        {
        }

        public static AgentBusinessUnitUnresolvedErrorQueryBuilderDsl Of()
        {
            return new AgentBusinessUnitUnresolvedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentBusinessUnitUnresolvedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentBusinessUnitUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentBusinessUnitUnresolvedErrorQueryBuilderDsl>(p, AgentBusinessUnitUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentBusinessUnitUnresolvedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentBusinessUnitUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentBusinessUnitUnresolvedErrorQueryBuilderDsl>(p, AgentBusinessUnitUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
