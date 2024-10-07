// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SearchNotReadyErrorQueryBuilderDsl
    {
        public SearchNotReadyErrorQueryBuilderDsl()
        {
        }

        public static SearchNotReadyErrorQueryBuilderDsl Of()
        {
            return new SearchNotReadyErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchNotReadyErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SearchNotReadyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SearchNotReadyErrorQueryBuilderDsl>(p, SearchNotReadyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchNotReadyErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SearchNotReadyErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SearchNotReadyErrorQueryBuilderDsl>(p, SearchNotReadyErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
