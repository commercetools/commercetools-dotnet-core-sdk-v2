// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class QueryComplexityLimitExceededErrorQueryBuilderDsl
    {
        public QueryComplexityLimitExceededErrorQueryBuilderDsl()
        {
        }

        public static QueryComplexityLimitExceededErrorQueryBuilderDsl Of()
        {
            return new QueryComplexityLimitExceededErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QueryComplexityLimitExceededErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<QueryComplexityLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<QueryComplexityLimitExceededErrorQueryBuilderDsl>(p, QueryComplexityLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QueryComplexityLimitExceededErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<QueryComplexityLimitExceededErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<QueryComplexityLimitExceededErrorQueryBuilderDsl>(p, QueryComplexityLimitExceededErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
