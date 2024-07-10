// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLObjectNotFoundErrorQueryBuilderDsl
    {
        public GraphQLObjectNotFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLObjectNotFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLObjectNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLObjectNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLObjectNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLObjectNotFoundErrorQueryBuilderDsl>(p, GraphQLObjectNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
