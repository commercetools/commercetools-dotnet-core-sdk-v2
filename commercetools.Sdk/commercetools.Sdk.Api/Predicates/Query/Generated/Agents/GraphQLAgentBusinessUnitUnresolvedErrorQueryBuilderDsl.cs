// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Agents
{

    public partial class GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl
    {
        public GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl Of()
        {
            return new GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl>(p, GraphQLAgentBusinessUnitUnresolvedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
