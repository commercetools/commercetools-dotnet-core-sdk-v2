// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SearchDeactivatedErrorQueryBuilderDsl
    {
        public SearchDeactivatedErrorQueryBuilderDsl()
        {
        }

        public static SearchDeactivatedErrorQueryBuilderDsl Of()
        {
            return new SearchDeactivatedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchDeactivatedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SearchDeactivatedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SearchDeactivatedErrorQueryBuilderDsl>(p, SearchDeactivatedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchDeactivatedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SearchDeactivatedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SearchDeactivatedErrorQueryBuilderDsl>(p, SearchDeactivatedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
