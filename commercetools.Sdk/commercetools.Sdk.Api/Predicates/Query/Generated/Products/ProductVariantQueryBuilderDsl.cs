using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductVariantQueryBuilderDsl
    {
        public ProductVariantQueryBuilderDsl()
        {
        }

        public static ProductVariantQueryBuilderDsl Of()
        {
            return new ProductVariantQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, long> Id()
        {
            return new ComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<ProductVariantQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductVariantQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductVariantQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductVariantQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<ProductVariantQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> Availability(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantAvailabilityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantAvailabilityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("availability"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantAvailabilityQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, bool> IsMatchingVariant()
        {
            return new ComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isMatchingVariant")),
            p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductVariantQueryBuilderDsl> ScopedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ScopedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ScopedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("scopedPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ScopedPriceQueryBuilderDsl.Of())),
                ProductVariantQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, bool> ScopedPriceDiscounted()
        {
            return new ComparisonPredicateBuilder<ProductVariantQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scopedPriceDiscounted")),
            p => new CombinationQueryPredicate<ProductVariantQueryBuilderDsl>(p, ProductVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
