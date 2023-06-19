using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductQueryBuilderDsl
    {
        public ProductQueryBuilderDsl()
        {
        }

        public static ProductQueryBuilderDsl Of()
        {
            return new ProductQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductQueryBuilderDsl>(p, ProductQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductQueryBuilderDsl>(p, ProductQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductQueryBuilderDsl>(p, ProductQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductQueryBuilderDsl>(p, ProductQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductQueryBuilderDsl>(p, ProductQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductQueryBuilderDsl> ProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductQueryBuilderDsl> MasterData(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductCatalogDataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductCatalogDataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("masterData"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductCatalogDataQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductQueryBuilderDsl> ReviewRatingStatistics(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("reviewRatingStatistics"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewRatingStatisticsQueryBuilderDsl.Of())),
                ProductQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductQueryBuilderDsl, string> PriceMode()
        {
            return new ComparisonPredicateBuilder<ProductQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceMode")),
            p => new CombinationQueryPredicate<ProductQueryBuilderDsl>(p, ProductQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
