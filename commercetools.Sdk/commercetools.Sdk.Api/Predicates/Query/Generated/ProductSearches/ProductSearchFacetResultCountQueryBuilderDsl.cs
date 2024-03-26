// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchFacetResultCountQueryBuilderDsl
    {
        public ProductSearchFacetResultCountQueryBuilderDsl()
        {
        }

        public static ProductSearchFacetResultCountQueryBuilderDsl Of()
        {
            return new ProductSearchFacetResultCountQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchFacetResultCountQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultCountQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultCountQueryBuilderDsl>(p, ProductSearchFacetResultCountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchFacetResultCountQueryBuilderDsl, long> Value()
        {
            return new ComparisonPredicateBuilder<ProductSearchFacetResultCountQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSearchFacetResultCountQueryBuilderDsl>(p, ProductSearchFacetResultCountQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
