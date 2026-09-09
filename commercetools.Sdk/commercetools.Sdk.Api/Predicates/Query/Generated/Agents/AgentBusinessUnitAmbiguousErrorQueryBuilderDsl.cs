// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class AgentBusinessUnitAmbiguousErrorQueryBuilderDsl
    {
        public AgentBusinessUnitAmbiguousErrorQueryBuilderDsl()
        {
        }

        public static AgentBusinessUnitAmbiguousErrorQueryBuilderDsl Of()
        {
            return new AgentBusinessUnitAmbiguousErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AgentBusinessUnitAmbiguousErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<AgentBusinessUnitAmbiguousErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<AgentBusinessUnitAmbiguousErrorQueryBuilderDsl>(p, AgentBusinessUnitAmbiguousErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AgentBusinessUnitAmbiguousErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<AgentBusinessUnitAmbiguousErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<AgentBusinessUnitAmbiguousErrorQueryBuilderDsl>(p, AgentBusinessUnitAmbiguousErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
