using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringAddVariantActionQueryBuilderDsl
    {
        public ProductTailoringAddVariantActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringAddVariantActionQueryBuilderDsl Of()
        {
            return new ProductTailoringAddVariantActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(p, ProductTailoringAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(p, ProductTailoringAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(p, ProductTailoringAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductTailoringAddVariantActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(p, ProductTailoringAddVariantActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                ProductTailoringAddVariantActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(p, ProductTailoringAddVariantActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringAddVariantActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringAddVariantActionQueryBuilderDsl>(p, ProductTailoringAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
