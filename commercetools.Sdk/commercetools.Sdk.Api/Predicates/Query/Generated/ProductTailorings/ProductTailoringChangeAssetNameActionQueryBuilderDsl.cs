using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringChangeAssetNameActionQueryBuilderDsl
    {
        public ProductTailoringChangeAssetNameActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringChangeAssetNameActionQueryBuilderDsl Of()
        {
            return new ProductTailoringChangeAssetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(p, ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(p, ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(p, ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(p, ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(p, ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(p, ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringChangeAssetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of);
        }


    }
}
