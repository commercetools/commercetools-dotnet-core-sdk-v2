using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductAddVariantActionQueryBuilderDsl
    {
        public ProductAddVariantActionQueryBuilderDsl()
        {
        }

        public static ProductAddVariantActionQueryBuilderDsl Of()
        {
            return new ProductAddVariantActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl> Prices(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("prices"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceDraftQueryBuilderDsl.Of())),
                ProductAddVariantActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl> Prices()
        {
            return new CollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("prices")),
                    p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                ProductAddVariantActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                ProductAddVariantActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductAddVariantActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                ProductAddVariantActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<ProductAddVariantActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<ProductAddVariantActionQueryBuilderDsl>(p, ProductAddVariantActionQueryBuilderDsl.Of));
        }

    }
}
