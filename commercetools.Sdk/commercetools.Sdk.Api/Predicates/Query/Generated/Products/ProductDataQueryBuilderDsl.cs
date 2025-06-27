using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductDataQueryBuilderDsl
    {
        public ProductDataQueryBuilderDsl()
        {
        }

        public static ProductDataQueryBuilderDsl Of()
        {
            return new ProductDataQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> Categories(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categories"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDataQueryBuilderDsl> Categories()
        {
            return new CollectionPredicateBuilder<ProductDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("categories")),
                    p => new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(p, ProductDataQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> CategoryOrderHints(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categoryOrderHints"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> MasterVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("masterVariant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> Variants(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDataQueryBuilderDsl> Variants()
        {
            return new CollectionPredicateBuilder<ProductDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variants")),
                    p => new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(p, ProductDataQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> SearchKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("searchKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDataQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDataQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductDataQueryBuilderDsl>(p, ProductDataQueryBuilderDsl.Of));
        }

    }
}
