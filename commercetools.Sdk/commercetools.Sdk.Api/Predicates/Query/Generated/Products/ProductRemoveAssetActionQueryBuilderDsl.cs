// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRemoveAssetActionQueryBuilderDsl
    {
        public ProductRemoveAssetActionQueryBuilderDsl()
        {
        }

        public static ProductRemoveAssetActionQueryBuilderDsl Of()
        {
            return new ProductRemoveAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRemoveAssetActionQueryBuilderDsl>(p, ProductRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductRemoveAssetActionQueryBuilderDsl>(p, ProductRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductRemoveAssetActionQueryBuilderDsl>(p, ProductRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductRemoveAssetActionQueryBuilderDsl>(p, ProductRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductRemoveAssetActionQueryBuilderDsl>(p, ProductRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductRemoveAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductRemoveAssetActionQueryBuilderDsl>(p, ProductRemoveAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
