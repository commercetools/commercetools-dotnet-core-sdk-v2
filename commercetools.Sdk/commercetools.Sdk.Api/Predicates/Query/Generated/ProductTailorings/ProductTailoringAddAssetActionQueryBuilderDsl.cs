using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringAddAssetActionQueryBuilderDsl
    {
        public ProductTailoringAddAssetActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringAddAssetActionQueryBuilderDsl Of()
        {
            return new ProductTailoringAddAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl>(p, ProductTailoringAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl>(p, ProductTailoringAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl>(p, ProductTailoringAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl>(p, ProductTailoringAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl> Asset(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("asset"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                ProductTailoringAddAssetActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<ProductTailoringAddAssetActionQueryBuilderDsl>(p, ProductTailoringAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
