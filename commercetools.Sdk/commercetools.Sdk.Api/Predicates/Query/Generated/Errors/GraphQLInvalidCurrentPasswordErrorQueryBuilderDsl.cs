// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl
    {
        public GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl>(p, GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
