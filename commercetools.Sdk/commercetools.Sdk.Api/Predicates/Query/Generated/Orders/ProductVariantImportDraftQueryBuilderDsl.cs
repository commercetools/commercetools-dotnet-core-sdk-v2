using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ProductVariantImportDraftQueryBuilderDsl
    {
        public ProductVariantImportDraftQueryBuilderDsl()
        {
        }

        public static ProductVariantImportDraftQueryBuilderDsl Of()
        {
            return new ProductVariantImportDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(p, ProductVariantImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(p, ProductVariantImportDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductVariantImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(p, ProductVariantImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductVariantImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(p, ProductVariantImportDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductVariantImportDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductVariantImportDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductVariantImportDraftQueryBuilderDsl>(p, ProductVariantImportDraftQueryBuilderDsl.Of));
        }

    }
}
