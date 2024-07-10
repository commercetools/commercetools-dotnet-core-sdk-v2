using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetAssetDescriptionActionQueryBuilderDsl
    {
        public ProductSetAssetDescriptionActionQueryBuilderDsl()
        {
        }

        public static ProductSetAssetDescriptionActionQueryBuilderDsl Of()
        {
            return new ProductSetAssetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(p, ProductSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(p, ProductSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(p, ProductSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(p, ProductSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(p, ProductSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<ProductSetAssetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(p, ProductSetAssetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetAssetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSetAssetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
