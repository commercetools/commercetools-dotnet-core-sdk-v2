// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetDistinctStartsWithQueryBuilderDsl
    {
        public ProductSearchFacetDistinctStartsWithQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetDistinctStartsWithQueryBuilderDsl Of()
        {
            return new ProductSearchFacetDistinctStartsWithQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetDistinctStartsWithQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctStartsWithQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctStartsWithQueryBuilderDsl>(p, ProductSearchFacetDistinctStartsWithQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetDistinctStartsWithQueryBuilderDsl, bool> CaseInsensitive()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetDistinctStartsWithQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("caseInsensitive")),
            p => new CombinationQueryPredicate<ProductSearchFacetDistinctStartsWithQueryBuilderDsl>(p, ProductSearchFacetDistinctStartsWithQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
