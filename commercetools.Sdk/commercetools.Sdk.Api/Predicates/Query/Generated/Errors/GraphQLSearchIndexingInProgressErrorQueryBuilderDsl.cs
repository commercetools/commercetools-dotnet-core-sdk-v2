// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSearchIndexingInProgressErrorQueryBuilderDsl
    {
        public GraphQLSearchIndexingInProgressErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSearchIndexingInProgressErrorQueryBuilderDsl Of()
        {
            return new GraphQLSearchIndexingInProgressErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSearchIndexingInProgressErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSearchIndexingInProgressErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSearchIndexingInProgressErrorQueryBuilderDsl>(p, GraphQLSearchIndexingInProgressErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
