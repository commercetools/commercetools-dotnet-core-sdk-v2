using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductVariantTailoringQueryBuilderDsl
    {
        public ProductVariantTailoringQueryBuilderDsl()
        {
        }

        public static ProductVariantTailoringQueryBuilderDsl Of()
        {
            return new ProductVariantTailoringQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantTailoringQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantTailoringQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(p, ProductVariantTailoringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductVariantTailoringQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantTailoringQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductVariantTailoringQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(p, ProductVariantTailoringQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                ProductVariantTailoringQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantTailoringQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<ProductVariantTailoringQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(p, ProductVariantTailoringQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAttributeQueryBuilderDsl.Of())),
                ProductVariantTailoringQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantTailoringQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductVariantTailoringQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductVariantTailoringQueryBuilderDsl>(p, ProductVariantTailoringQueryBuilderDsl.Of));
        }

    }
}
