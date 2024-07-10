using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetAssetKeyActionQueryBuilderDsl
    {
        public ProductSetAssetKeyActionQueryBuilderDsl()
        {
        }

        public static ProductSetAssetKeyActionQueryBuilderDsl Of()
        {
            return new ProductSetAssetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetAssetKeyActionQueryBuilderDsl>(p, ProductSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetAssetKeyActionQueryBuilderDsl>(p, ProductSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetAssetKeyActionQueryBuilderDsl>(p, ProductSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetAssetKeyActionQueryBuilderDsl>(p, ProductSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductSetAssetKeyActionQueryBuilderDsl>(p, ProductSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductSetAssetKeyActionQueryBuilderDsl>(p, ProductSetAssetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
