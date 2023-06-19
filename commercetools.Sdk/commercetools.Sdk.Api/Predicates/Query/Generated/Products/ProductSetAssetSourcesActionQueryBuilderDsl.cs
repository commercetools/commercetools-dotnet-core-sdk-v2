using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetAssetSourcesActionQueryBuilderDsl
    {
        public ProductSetAssetSourcesActionQueryBuilderDsl()
        {
        }

        public static ProductSetAssetSourcesActionQueryBuilderDsl Of()
        {
            return new ProductSetAssetSourcesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl> Sources(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("sources"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetSourceQueryBuilderDsl.Of())),
                ProductSetAssetSourcesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl> Sources()
        {
            return new CollectionPredicateBuilder<ProductSetAssetSourcesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sources")),
                    p => new CombinationQueryPredicate<ProductSetAssetSourcesActionQueryBuilderDsl>(p, ProductSetAssetSourcesActionQueryBuilderDsl.Of));
        }

    }
}
