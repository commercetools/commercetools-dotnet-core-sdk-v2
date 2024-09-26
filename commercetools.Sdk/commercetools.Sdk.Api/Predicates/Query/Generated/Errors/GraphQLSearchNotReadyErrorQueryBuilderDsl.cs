// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSearchNotReadyErrorQueryBuilderDsl
    {
        public GraphQLSearchNotReadyErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSearchNotReadyErrorQueryBuilderDsl Of()
        {
            return new GraphQLSearchNotReadyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSearchNotReadyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSearchNotReadyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSearchNotReadyErrorQueryBuilderDsl>(p, GraphQLSearchNotReadyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
