// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class BulkOperationMaxItemsExceededErrorQueryBuilderDsl
    {
        public BulkOperationMaxItemsExceededErrorQueryBuilderDsl()
        {
        }

        public static BulkOperationMaxItemsExceededErrorQueryBuilderDsl Of()
        {
            return new BulkOperationMaxItemsExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<BulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, BulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<BulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, BulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<BulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, BulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, long> Provided()
        {
            return new ComparisonPredicateBuilder<BulkOperationMaxItemsExceededErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("provided")),
            p => new CombinationQueryPredicate<BulkOperationMaxItemsExceededErrorQueryBuilderDsl>(p, BulkOperationMaxItemsExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
