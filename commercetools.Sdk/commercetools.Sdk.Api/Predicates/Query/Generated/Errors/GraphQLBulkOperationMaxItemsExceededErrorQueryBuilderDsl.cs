// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl
    {
        public GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl()
        {
        }

        public static GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl Of()
        {
            return new GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl, long> Provided()
        {
            return new ComparisonPredicateBuilder<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("provided")),
            p => new CombinationQueryPredicate<GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, GraphQLBulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
