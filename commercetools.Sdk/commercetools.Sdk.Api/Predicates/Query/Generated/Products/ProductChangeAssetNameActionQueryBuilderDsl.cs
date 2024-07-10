using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductChangeAssetNameActionQueryBuilderDsl
    {
        public ProductChangeAssetNameActionQueryBuilderDsl()
        {
        }

        public static ProductChangeAssetNameActionQueryBuilderDsl Of()
        {
            return new ProductChangeAssetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(p, ProductChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(p, ProductChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(p, ProductChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(p, ProductChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(p, ProductChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductChangeAssetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(p, ProductChangeAssetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductChangeAssetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductChangeAssetNameActionQueryBuilderDsl.Of);
        }


    }
}
