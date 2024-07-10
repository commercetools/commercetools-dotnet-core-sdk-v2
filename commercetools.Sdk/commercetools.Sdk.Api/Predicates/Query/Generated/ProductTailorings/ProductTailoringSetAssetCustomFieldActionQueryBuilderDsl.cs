using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl
    {
        public ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>(p, ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
