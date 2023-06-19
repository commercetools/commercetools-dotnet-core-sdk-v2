// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidOperationErrorQueryBuilderDsl
    {
        public GraphQLInvalidOperationErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidOperationErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidOperationErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidOperationErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidOperationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidOperationErrorQueryBuilderDsl>(p, GraphQLInvalidOperationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
