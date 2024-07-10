// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLPendingOperationErrorQueryBuilderDsl
    {
        public GraphQLPendingOperationErrorQueryBuilderDsl()
        {
        }

        public static GraphQLPendingOperationErrorQueryBuilderDsl Of()
        {
            return new GraphQLPendingOperationErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLPendingOperationErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLPendingOperationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLPendingOperationErrorQueryBuilderDsl>(p, GraphQLPendingOperationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
