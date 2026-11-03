// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class TooManyRequestsErrorQueryBuilderDsl
    {
        public TooManyRequestsErrorQueryBuilderDsl()
        {
        }

        public static TooManyRequestsErrorQueryBuilderDsl Of()
        {
            return new TooManyRequestsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TooManyRequestsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<TooManyRequestsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<TooManyRequestsErrorQueryBuilderDsl>(p, TooManyRequestsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TooManyRequestsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<TooManyRequestsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<TooManyRequestsErrorQueryBuilderDsl>(p, TooManyRequestsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
