using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductProjectionQueryBuilderDsl
    {
        public ProductProjectionQueryBuilderDsl()
        {
        }

        public static ProductProjectionQueryBuilderDsl Of()
        {
            return new ProductProjectionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> ProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> Categories(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categories"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductProjectionQueryBuilderDsl> Categories()
        {
            return new CollectionPredicateBuilder<ProductProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("categories")),
                    p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> CategoryOrderHints(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categoryOrderHints"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> SearchKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("searchKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.SearchKeywordsQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, bool> HasStagedChanges()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("hasStagedChanges")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, bool> Published()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("published")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> MasterVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("masterVariant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> Variants(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductProjectionQueryBuilderDsl> Variants()
        {
            return new CollectionPredicateBuilder<ProductProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variants")),
                    p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> ReviewRatingStatistics(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("reviewRatingStatistics"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<ProductProjectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductProjectionQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductProjectionQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductProjectionQueryBuilderDsl>(p, ProductProjectionQueryBuilderDsl.Of));
        }

    }
}
