using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringDataQueryBuilderDsl
    {
        public ProductTailoringDataQueryBuilderDsl()
        {
        }

        public static ProductTailoringDataQueryBuilderDsl Of()
        {
            return new ProductTailoringDataQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> MetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaTitle"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> MetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaKeywords"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl> Variants(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductVariantTailoringQueryBuilderDsl.Of())),
                ProductTailoringDataQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTailoringDataQueryBuilderDsl> Variants()
        {
            return new CollectionPredicateBuilder<ProductTailoringDataQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variants")),
                    p => new CombinationQueryPredicate<ProductTailoringDataQueryBuilderDsl>(p, ProductTailoringDataQueryBuilderDsl.Of));
        }

    }
}
