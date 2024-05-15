// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Searches
{

    public partial class SearchMatchingVariantQueryBuilderDsl
    {
        public SearchMatchingVariantQueryBuilderDsl()
        {
        }

        public static SearchMatchingVariantQueryBuilderDsl Of()
        {
            return new SearchMatchingVariantQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<SearchMatchingVariantQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<SearchMatchingVariantQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<SearchMatchingVariantQueryBuilderDsl>(p, SearchMatchingVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<SearchMatchingVariantQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<SearchMatchingVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<SearchMatchingVariantQueryBuilderDsl>(p, SearchMatchingVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
