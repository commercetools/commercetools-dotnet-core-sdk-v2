// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class SearchFacetPathNotFoundErrorQueryBuilderDsl
    {
        public SearchFacetPathNotFoundErrorQueryBuilderDsl()
        {
        }

        public static SearchFacetPathNotFoundErrorQueryBuilderDsl Of()
        {
            return new SearchFacetPathNotFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchFacetPathNotFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<SearchFacetPathNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<SearchFacetPathNotFoundErrorQueryBuilderDsl>(p, SearchFacetPathNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchFacetPathNotFoundErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<SearchFacetPathNotFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<SearchFacetPathNotFoundErrorQueryBuilderDsl>(p, SearchFacetPathNotFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
