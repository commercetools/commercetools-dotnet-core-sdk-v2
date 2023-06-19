using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductUpdateActionQueryBuilderDsl
    {
        public ProductUpdateActionQueryBuilderDsl()
        {
        }

        public static ProductUpdateActionQueryBuilderDsl Of()
        {
            return new ProductUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(p, ProductUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsAddAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductAddAssetActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsAddExternalImage(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddExternalImageActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddExternalImageActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductAddExternalImageActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsAddPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductAddPriceActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsAddToCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddToCategoryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddToCategoryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductAddToCategoryActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsAddVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddVariantActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductAddVariantActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductAddVariantActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsChangeAssetName(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeAssetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeAssetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeAssetNameActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsChangeAssetOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeAssetOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeAssetOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeAssetOrderActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsChangeMasterVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeMasterVariantActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeMasterVariantActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeMasterVariantActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeNameActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsChangePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangePriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangePriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductChangePriceActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsChangeSlug(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeSlugActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeSlugActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductChangeSlugActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsLegacySetSku(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductLegacySetSkuActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductLegacySetSkuActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductLegacySetSkuActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsMoveImageToPosition(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductMoveImageToPositionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductMoveImageToPositionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductMoveImageToPositionActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsPublish(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductPublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductPublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductPublishActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRemoveAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveAssetActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRemoveFromCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveFromCategoryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveFromCategoryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveFromCategoryActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRemoveImage(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveImageActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveImageActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveImageActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRemovePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemovePriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemovePriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRemovePriceActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRemoveVariant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveVariantActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveVariantActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRemoveVariantActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRevertStagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRevertStagedChangesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRevertStagedChangesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRevertStagedChangesActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsRevertStagedVariantChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductRevertStagedVariantChangesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductRevertStagedVariantChangesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductRevertStagedVariantChangesActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAssetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetCustomFieldActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAssetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetCustomTypeActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAssetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetDescriptionActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAssetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetKeyActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAssetSources(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetSourcesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetSourcesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetSourcesActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAssetTags(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetTagsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetTagsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAssetTagsActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAttribute(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAttributeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAttributeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAttributeActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetAttributeInAllVariants(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAttributeInAllVariantsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAttributeInAllVariantsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetAttributeInAllVariantsActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetCategoryOrderHint(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetCategoryOrderHintActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetCategoryOrderHintActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetCategoryOrderHintActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetDescriptionActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetDiscountedPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetDiscountedPriceActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetDiscountedPriceActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetDiscountedPriceActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetImageLabel(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetImageLabelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetImageLabelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetImageLabelActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetKeyActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetMetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaDescriptionActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetMetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaKeywordsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaKeywordsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaKeywordsActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetMetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaTitleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaTitleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetMetaTitleActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetPriceKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPriceKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPriceKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPriceKeyActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetPriceMode(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPriceModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPriceModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPriceModeActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetPrices(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPricesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPricesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetPricesActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetProductPriceCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductPriceCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductPriceCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductPriceCustomFieldActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetProductPriceCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductPriceCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductPriceCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductPriceCustomTypeActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetProductVariantKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductVariantKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductVariantKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetProductVariantKeyActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetSearchKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetSearchKeywordsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetSearchKeywordsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetSearchKeywordsActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetSku(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetSkuActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetSkuActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetSkuActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsSetTaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetTaxCategoryActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductSetTaxCategoryActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductSetTaxCategoryActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductTransitionStateActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl> AsUnpublish(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductUnpublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductUnpublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductUnpublishActionQueryBuilderDsl.Of()),
                ProductUpdateActionQueryBuilderDsl.Of);
        }
    }
}
