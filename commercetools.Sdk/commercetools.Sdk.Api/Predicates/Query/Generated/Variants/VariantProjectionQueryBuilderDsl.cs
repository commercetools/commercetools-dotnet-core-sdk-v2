using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantProjectionQueryBuilderDsl
    {
        public VariantProjectionQueryBuilderDsl()
        {
        }

        public static VariantProjectionQueryBuilderDsl Of()
        {
            return new VariantProjectionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Categories(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categories"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryReferenceQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantProjectionQueryBuilderDsl> Categories()
        {
            return new CollectionPredicateBuilder<VariantProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("categories")),
                    p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> CategoryOrderHints(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("categoryOrderHints"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.CategoryOrderHintsQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Images(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("images"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantProjectionQueryBuilderDsl> Images()
        {
            return new CollectionPredicateBuilder<VariantProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("images")),
                    p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Assets(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("assets"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantProjectionQueryBuilderDsl> Assets()
        {
            return new CollectionPredicateBuilder<VariantProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assets")),
                    p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantProjectionQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantProjectionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantProjectionQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceQueryBuilderDsl.Of())),
                VariantProjectionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, bool> Default()
        {
            return new ComparisonPredicateBuilder<VariantProjectionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("default")),
            p => new CombinationQueryPredicate<VariantProjectionQueryBuilderDsl>(p, VariantProjectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
