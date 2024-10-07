// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringChangeAssetOrderActionQueryBuilderDsl
    {
        public ProductTailoringChangeAssetOrderActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringChangeAssetOrderActionQueryBuilderDsl Of()
        {
            return new ProductTailoringChangeAssetOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetOrderActionQueryBuilderDsl>(p, ProductTailoringChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetOrderActionQueryBuilderDsl>(p, ProductTailoringChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetOrderActionQueryBuilderDsl>(p, ProductTailoringChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetOrderActionQueryBuilderDsl>(p, ProductTailoringChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, string> AssetOrder()
        {
            return new ComparableCollectionPredicateBuilder<ProductTailoringChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetOrder")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetOrderActionQueryBuilderDsl>(p, ProductTailoringChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
