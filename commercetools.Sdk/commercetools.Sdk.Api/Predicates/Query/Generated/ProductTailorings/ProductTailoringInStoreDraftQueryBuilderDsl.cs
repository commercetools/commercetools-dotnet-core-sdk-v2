using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringInStoreDraftQueryBuilderDsl
    {
        public ProductTailoringInStoreDraftQueryBuilderDsl()
        {
        }

        public static ProductTailoringInStoreDraftQueryBuilderDsl Of()
        {
            return new ProductTailoringInStoreDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringInStoreDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductTailoringInStoreDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(p, ProductTailoringInStoreDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductResourceIdentifierQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringInStoreDraftQueryBuilderDsl, bool> Publish()
        {
            return new ComparisonPredicateBuilder<ProductTailoringInStoreDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("publish")),
            p => new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(p, ProductTailoringInStoreDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl> Variants(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringDraftQueryBuilderDsl.Of())),
                ProductTailoringInStoreDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTailoringInStoreDraftQueryBuilderDsl> Variants()
        {
            return new CollectionPredicateBuilder<ProductTailoringInStoreDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variants")),
                    p => new CombinationQueryPredicate<ProductTailoringInStoreDraftQueryBuilderDsl>(p, ProductTailoringInStoreDraftQueryBuilderDsl.Of));
        }

    }
}
