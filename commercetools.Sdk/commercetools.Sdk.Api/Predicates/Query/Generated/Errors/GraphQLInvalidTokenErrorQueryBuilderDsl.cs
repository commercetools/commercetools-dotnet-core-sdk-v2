// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidTokenErrorQueryBuilderDsl
    {
        public GraphQLInvalidTokenErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidTokenErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidTokenErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidTokenErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidTokenErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidTokenErrorQueryBuilderDsl>(p, GraphQLInvalidTokenErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
