using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductVariantTailoringDraftQueryBuilderDsl
    {
        public ProductVariantTailoringDraftQueryBuilderDsl()
        {
        }

        public static ProductVariantTailoringDraftQueryBuilderDsl Of()
        {
            return new ProductVariantTailoringDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(p, ProductVariantTailoringDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(p, ProductVariantTailoringDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductVariantTailoringDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(p, ProductVariantTailoringDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                ProductVariantTailoringDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(p, ProductVariantTailoringDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAttributeQueryBuilderDsl.Of())),
                ProductVariantTailoringDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductVariantTailoringDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductVariantTailoringDraftQueryBuilderDsl>(p, ProductVariantTailoringDraftQueryBuilderDsl.Of));
        }

    }
}
