using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductChangeAssetOrderActionQueryBuilderDsl
    {
        public ProductChangeAssetOrderActionQueryBuilderDsl()
        {
        }

        public static ProductChangeAssetOrderActionQueryBuilderDsl Of()
        {
            return new ProductChangeAssetOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductChangeAssetOrderActionQueryBuilderDsl>(p, ProductChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductChangeAssetOrderActionQueryBuilderDsl>(p, ProductChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductChangeAssetOrderActionQueryBuilderDsl>(p, ProductChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductChangeAssetOrderActionQueryBuilderDsl>(p, ProductChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, string> AssetOrder()
        {
            return new ComparableCollectionPredicateBuilder<ProductChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetOrder")),
            p => new CombinationQueryPredicate<ProductChangeAssetOrderActionQueryBuilderDsl>(p, ProductChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
