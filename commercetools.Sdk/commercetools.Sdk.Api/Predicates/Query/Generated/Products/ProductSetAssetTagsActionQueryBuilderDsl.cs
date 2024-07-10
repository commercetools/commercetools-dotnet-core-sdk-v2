using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetAssetTagsActionQueryBuilderDsl
    {
        public ProductSetAssetTagsActionQueryBuilderDsl()
        {
        }

        public static ProductSetAssetTagsActionQueryBuilderDsl Of()
        {
            return new ProductSetAssetTagsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string> Tags()
        {
            return new ComparableCollectionPredicateBuilder<ProductSetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tags")),
            p => new CombinationQueryPredicate<ProductSetAssetTagsActionQueryBuilderDsl>(p, ProductSetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
