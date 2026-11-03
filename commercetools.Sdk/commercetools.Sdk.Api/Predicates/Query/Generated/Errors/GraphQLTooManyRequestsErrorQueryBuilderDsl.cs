// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLTooManyRequestsErrorQueryBuilderDsl
    {
        public GraphQLTooManyRequestsErrorQueryBuilderDsl()
        {
        }

        public static GraphQLTooManyRequestsErrorQueryBuilderDsl Of()
        {
            return new GraphQLTooManyRequestsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLTooManyRequestsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLTooManyRequestsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLTooManyRequestsErrorQueryBuilderDsl>(p, GraphQLTooManyRequestsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
