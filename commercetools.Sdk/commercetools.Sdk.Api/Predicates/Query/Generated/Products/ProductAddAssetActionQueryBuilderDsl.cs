using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductAddAssetActionQueryBuilderDsl
    {
        public ProductAddAssetActionQueryBuilderDsl()
        {
        }

        public static ProductAddAssetActionQueryBuilderDsl Of()
        {
            return new ProductAddAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl>(p, ProductAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl>(p, ProductAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl>(p, ProductAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl>(p, ProductAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl> Asset(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("asset"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                ProductAddAssetActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<ProductAddAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<ProductAddAssetActionQueryBuilderDsl>(p, ProductAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
