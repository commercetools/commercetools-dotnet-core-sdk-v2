using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductVariantDraftQueryBuilderDsl
    {
        public ProductVariantDraftQueryBuilderDsl()
        {
        }

        public static ProductVariantDraftQueryBuilderDsl Of()
        {
            return new ProductVariantDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductVariantDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(p, ProductVariantDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductVariantDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(p, ProductVariantDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductVariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(p, ProductVariantDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductVariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(p, ProductVariantDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductVariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(p, ProductVariantDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                ProductVariantDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<ProductVariantDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<ProductVariantDraftQueryBuilderDsl>(p, ProductVariantDraftQueryBuilderDsl.Of));
        }

    }
}
