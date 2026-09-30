// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl
    {
        public GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl>(p, GraphQLAgentBusinessUnitAmbiguousErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
