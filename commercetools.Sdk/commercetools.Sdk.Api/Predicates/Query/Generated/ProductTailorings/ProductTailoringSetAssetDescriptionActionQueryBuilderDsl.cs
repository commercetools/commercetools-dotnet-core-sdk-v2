using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetAssetDescriptionActionQueryBuilderDsl
    {
        public ProductTailoringSetAssetDescriptionActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetAssetDescriptionActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetAssetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
