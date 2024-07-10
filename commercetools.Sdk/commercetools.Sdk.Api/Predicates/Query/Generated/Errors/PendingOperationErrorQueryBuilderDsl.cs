// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class PendingOperationErrorQueryBuilderDsl
    {
        public PendingOperationErrorQueryBuilderDsl()
        {
        }

        public static PendingOperationErrorQueryBuilderDsl Of()
        {
            return new PendingOperationErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PendingOperationErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<PendingOperationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<PendingOperationErrorQueryBuilderDsl>(p, PendingOperationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PendingOperationErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<PendingOperationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<PendingOperationErrorQueryBuilderDsl>(p, PendingOperationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
