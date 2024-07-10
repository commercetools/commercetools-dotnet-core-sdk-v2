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

        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsAddAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddAssetActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsAddExternalImage(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddExternalImageActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddExternalImageActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddExternalImageActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsAddVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddVariantActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddVariantActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringAddVariantActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsChangeAssetName(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringChangeAssetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringChangeAssetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringChangeAssetNameActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsChangeAssetOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringChangeAssetOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringChangeAssetOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringChangeAssetOrderActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsMoveImageToPosition(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringMoveImageToPositionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringMoveImageToPositionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringMoveImageToPositionActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsPublish(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringPublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringPublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringPublishActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsRemoveAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveAssetActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsRemoveImage(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveImageActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveImageActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveImageActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsRemoveVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveVariantActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveVariantActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringRemoveVariantActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetAssetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetCustomFieldActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetAssetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetCustomTypeActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetAssetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetDescriptionActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetAssetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetKeyActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetAssetSources(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetSourcesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetSourcesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetSourcesActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetAssetTags(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetTagsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetTagsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetAssetTagsActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetDescriptionActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetImages(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetExternalImagesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetExternalImagesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetExternalImagesActionQueryBuilderDsl.Of()),
                ProductTailoringUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl> AsSetImageLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetImageLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetImageLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringSetImageLabelActionQueryBuilderDsl.Of()),
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
