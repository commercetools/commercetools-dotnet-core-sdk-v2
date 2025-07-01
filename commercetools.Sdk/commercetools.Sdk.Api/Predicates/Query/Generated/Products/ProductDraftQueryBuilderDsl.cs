using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductDraftQueryBuilderDsl
    {
        public ProductDraftQueryBuilderDsl()
        {
        }

        public static ProductDraftQueryBuilderDsl Of()
        {
            return new ProductDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> ProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeResourceIdentifierQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(p, ProductDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> Categories(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categories"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryResourceIdentifierQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDraftQueryBuilderDsl> Categories()
        {
            return new CollectionPredicateBuilder<ProductDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("categories")),
                    p => new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(p, ProductDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> CategoryOrderHints(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categoryOrderHints"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> MasterVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("masterVariant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantDraftQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> Variants(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantDraftQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDraftQueryBuilderDsl> Variants()
        {
            return new CollectionPredicateBuilder<ProductDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variants")),
                    p => new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(p, ProductDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> SearchKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("searchKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductDraftQueryBuilderDsl, bool> Publish()
        {
            return new ComparisonPredicateBuilder<ProductDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("publish")),
            p => new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(p, ProductDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDraftQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<ProductDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(p, ProductDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductDraftQueryBuilderDsl>(p, ProductDraftQueryBuilderDsl.Of));
        }

    }
}
