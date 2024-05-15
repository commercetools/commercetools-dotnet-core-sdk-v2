using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringUpdateActionQueryBuilderDsl
    {
        public ProductTailoringUpdateActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringUpdateActionQueryBuilderDsl Of()
        {
            return new ProductTailoringUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(p, ProductTailoringUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsPublish(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringPublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringPublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringPublishActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetDescriptionActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetMetaAttributes(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaAttributesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaAttributesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaAttributesActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetMetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaDescriptionActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetMetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaKeywordsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaKeywordsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaKeywordsActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetMetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaTitleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaTitleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetMetaTitleActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetNameActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetSlug(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetSlugActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetSlugActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetSlugActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsUnpublish(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringUnpublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringUnpublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringUnpublishActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
    }
}
