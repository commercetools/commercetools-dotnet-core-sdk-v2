// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchMatchingVariantQueryBuilderDsl
    {
        public ProductSearchMatchingVariantQueryBuilderDsl()
        {
        }

        public static ProductSearchMatchingVariantQueryBuilderDsl Of()
        {
            return new ProductSearchMatchingVariantQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchMatchingVariantQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductSearchMatchingVariantQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSearchMatchingVariantQueryBuilderDsl>(p, ProductSearchMatchingVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSearchMatchingVariantQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSearchMatchingVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSearchMatchingVariantQueryBuilderDsl>(p, ProductSearchMatchingVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
