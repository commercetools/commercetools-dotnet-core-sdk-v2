using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetAssetTagsActionQueryBuilderDsl
    {
        public ProductTailoringSetAssetTagsActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetAssetTagsActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetAssetTagsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string> Tags()
        {
            return new ComparableCollectionPredicateBuilder<ProductTailoringSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tags")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetTagsActionQueryBuilderDsl>(p, ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
