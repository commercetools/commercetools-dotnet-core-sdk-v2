// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductVariantSelectionIncludeOnlyQueryBuilderDsl
    {
        public ProductVariantSelectionIncludeOnlyQueryBuilderDsl()
        {
        }

        public static ProductVariantSelectionIncludeOnlyQueryBuilderDsl Of()
        {
            return new ProductVariantSelectionIncludeOnlyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantSelectionIncludeOnlyQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductVariantSelectionIncludeOnlyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductVariantSelectionIncludeOnlyQueryBuilderDsl>(p, ProductVariantSelectionIncludeOnlyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductVariantSelectionIncludeOnlyQueryBuilderDsl, string> Skus()
        {
            return new ComparableCollectionPredicateBuilder<ProductVariantSelectionIncludeOnlyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skus")),
            p => new CombinationQueryPredicate<ProductVariantSelectionIncludeOnlyQueryBuilderDsl>(p, ProductVariantSelectionIncludeOnlyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
