using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Products.ProductUpdateAction))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Sdk.Api.Models.Products.ProductAddAssetAction))]
    [SubTypeDiscriminator("addExternalImage", typeof(commercetools.Sdk.Api.Models.Products.ProductAddExternalImageAction))]
    [SubTypeDiscriminator("addPrice", typeof(commercetools.Sdk.Api.Models.Products.ProductAddPriceAction))]
    [SubTypeDiscriminator("addToCategory", typeof(commercetools.Sdk.Api.Models.Products.ProductAddToCategoryAction))]
    [SubTypeDiscriminator("addVariant", typeof(commercetools.Sdk.Api.Models.Products.ProductAddVariantAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeAssetOrderAction))]
    [SubTypeDiscriminator("changeMasterVariant", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeMasterVariantAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeNameAction))]
    [SubTypeDiscriminator("changePrice", typeof(commercetools.Sdk.Api.Models.Products.ProductChangePriceAction))]
    [SubTypeDiscriminator("changeSlug", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeSlugAction))]
    [SubTypeDiscriminator("legacySetSku", typeof(commercetools.Sdk.Api.Models.Products.ProductLegacySetSkuAction))]
    [SubTypeDiscriminator("moveImageToPosition", typeof(commercetools.Sdk.Api.Models.Products.ProductMoveImageToPositionAction))]
    [SubTypeDiscriminator("publish", typeof(commercetools.Sdk.Api.Models.Products.ProductPublishAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveAssetAction))]
    [SubTypeDiscriminator("removeFromCategory", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveFromCategoryAction))]
    [SubTypeDiscriminator("removeImage", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveImageAction))]
    [SubTypeDiscriminator("removePrice", typeof(commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction))]
    [SubTypeDiscriminator("removeVariant", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveVariantAction))]
    [SubTypeDiscriminator("revertStagedChanges", typeof(commercetools.Sdk.Api.Models.Products.ProductRevertStagedChangesAction))]
    [SubTypeDiscriminator("revertStagedVariantChanges", typeof(commercetools.Sdk.Api.Models.Products.ProductRevertStagedVariantChangesAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetKeyAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetTagsAction))]
    [SubTypeDiscriminator("setAttribute", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAttributeAction))]
    [SubTypeDiscriminator("setAttributeInAllVariants", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAttributeInAllVariantsAction))]
    [SubTypeDiscriminator("setCategoryOrderHint", typeof(commercetools.Sdk.Api.Models.Products.ProductSetCategoryOrderHintAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Products.ProductSetDescriptionAction))]
    [SubTypeDiscriminator("setDiscountedPrice", typeof(commercetools.Sdk.Api.Models.Products.ProductSetDiscountedPriceAction))]
    [SubTypeDiscriminator("setImageLabel", typeof(commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetKeyAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaTitleAction))]
    [SubTypeDiscriminator("setPriceKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetPriceKeyAction))]
    [SubTypeDiscriminator("setPriceMode", typeof(commercetools.Sdk.Api.Models.Products.ProductSetPriceModeAction))]
    [SubTypeDiscriminator("setPrices", typeof(commercetools.Sdk.Api.Models.Products.ProductSetPricesAction))]
    [SubTypeDiscriminator("setProductPriceCustomField", typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomFieldAction))]
    [SubTypeDiscriminator("setProductPriceCustomType", typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomTypeAction))]
    [SubTypeDiscriminator("setProductVariantKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductVariantKeyAction))]
    [SubTypeDiscriminator("setSearchKeywords", typeof(commercetools.Sdk.Api.Models.Products.ProductSetSearchKeywordsAction))]
    [SubTypeDiscriminator("setSku", typeof(commercetools.Sdk.Api.Models.Products.ProductSetSkuAction))]
    [SubTypeDiscriminator("setTaxCategory", typeof(commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.Products.ProductTransitionStateAction))]
    [SubTypeDiscriminator("unpublish", typeof(commercetools.Sdk.Api.Models.Products.ProductUnpublishAction))]
    public partial interface IProductUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProductUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.Products.ProductAddAssetAction AddAsset(Action<commercetools.Sdk.Api.Models.Products.ProductAddAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductAddAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductAddExternalImageAction AddExternalImage(Action<commercetools.Sdk.Api.Models.Products.ProductAddExternalImageAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductAddExternalImageAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductAddPriceAction AddPrice(Action<commercetools.Sdk.Api.Models.Products.ProductAddPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductAddPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductAddToCategoryAction AddToCategory(Action<commercetools.Sdk.Api.Models.Products.ProductAddToCategoryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductAddToCategoryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductAddVariantAction AddVariant(Action<commercetools.Sdk.Api.Models.Products.ProductAddVariantAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductAddVariantAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductChangeAssetNameAction ChangeAssetName(Action<commercetools.Sdk.Api.Models.Products.ProductChangeAssetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductChangeAssetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductChangeAssetOrderAction ChangeAssetOrder(Action<commercetools.Sdk.Api.Models.Products.ProductChangeAssetOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductChangeAssetOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductChangeMasterVariantAction ChangeMasterVariant(Action<commercetools.Sdk.Api.Models.Products.ProductChangeMasterVariantAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductChangeMasterVariantAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Products.ProductChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductChangePriceAction ChangePrice(Action<commercetools.Sdk.Api.Models.Products.ProductChangePriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductChangePriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductChangeSlugAction ChangeSlug(Action<commercetools.Sdk.Api.Models.Products.ProductChangeSlugAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductChangeSlugAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductLegacySetSkuAction LegacySetSku(Action<commercetools.Sdk.Api.Models.Products.ProductLegacySetSkuAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductLegacySetSkuAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductMoveImageToPositionAction MoveImageToPosition(Action<commercetools.Sdk.Api.Models.Products.ProductMoveImageToPositionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductMoveImageToPositionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductPublishAction Publish(Action<commercetools.Sdk.Api.Models.Products.ProductPublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductPublishAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRemoveAssetAction RemoveAsset(Action<commercetools.Sdk.Api.Models.Products.ProductRemoveAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRemoveAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRemoveFromCategoryAction RemoveFromCategory(Action<commercetools.Sdk.Api.Models.Products.ProductRemoveFromCategoryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRemoveFromCategoryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRemoveImageAction RemoveImage(Action<commercetools.Sdk.Api.Models.Products.ProductRemoveImageAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRemoveImageAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction RemovePrice(Action<commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRemoveVariantAction RemoveVariant(Action<commercetools.Sdk.Api.Models.Products.ProductRemoveVariantAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRemoveVariantAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRevertStagedChangesAction RevertStagedChanges(Action<commercetools.Sdk.Api.Models.Products.ProductRevertStagedChangesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRevertStagedChangesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductRevertStagedVariantChangesAction RevertStagedVariantChanges(Action<commercetools.Sdk.Api.Models.Products.ProductRevertStagedVariantChangesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductRevertStagedVariantChangesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomFieldAction SetAssetCustomField(Action<commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomTypeAction SetAssetCustomType(Action<commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAssetDescriptionAction SetAssetDescription(Action<commercetools.Sdk.Api.Models.Products.ProductSetAssetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAssetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAssetKeyAction SetAssetKey(Action<commercetools.Sdk.Api.Models.Products.ProductSetAssetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAssetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAssetSourcesAction SetAssetSources(Action<commercetools.Sdk.Api.Models.Products.ProductSetAssetSourcesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAssetSourcesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAssetTagsAction SetAssetTags(Action<commercetools.Sdk.Api.Models.Products.ProductSetAssetTagsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAssetTagsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAttributeAction SetAttribute(Action<commercetools.Sdk.Api.Models.Products.ProductSetAttributeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAttributeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetAttributeInAllVariantsAction SetAttributeInAllVariants(Action<commercetools.Sdk.Api.Models.Products.ProductSetAttributeInAllVariantsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetAttributeInAllVariantsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetCategoryOrderHintAction SetCategoryOrderHint(Action<commercetools.Sdk.Api.Models.Products.ProductSetCategoryOrderHintAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetCategoryOrderHintAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.Products.ProductSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetDiscountedPriceAction SetDiscountedPrice(Action<commercetools.Sdk.Api.Models.Products.ProductSetDiscountedPriceAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetDiscountedPriceAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction SetImageLabel(Action<commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Products.ProductSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetMetaDescriptionAction SetMetaDescription(Action<commercetools.Sdk.Api.Models.Products.ProductSetMetaDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetMetaDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetMetaKeywordsAction SetMetaKeywords(Action<commercetools.Sdk.Api.Models.Products.ProductSetMetaKeywordsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetMetaKeywordsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetMetaTitleAction SetMetaTitle(Action<commercetools.Sdk.Api.Models.Products.ProductSetMetaTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetMetaTitleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetPriceKeyAction SetPriceKey(Action<commercetools.Sdk.Api.Models.Products.ProductSetPriceKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetPriceKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetPriceModeAction SetPriceMode(Action<commercetools.Sdk.Api.Models.Products.ProductSetPriceModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetPriceModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetPricesAction SetPrices(Action<commercetools.Sdk.Api.Models.Products.ProductSetPricesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetPricesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomFieldAction SetProductPriceCustomField(Action<commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomTypeAction SetProductPriceCustomType(Action<commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetProductVariantKeyAction SetProductVariantKey(Action<commercetools.Sdk.Api.Models.Products.ProductSetProductVariantKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetProductVariantKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetSearchKeywordsAction SetSearchKeywords(Action<commercetools.Sdk.Api.Models.Products.ProductSetSearchKeywordsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetSearchKeywordsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetSkuAction SetSku(Action<commercetools.Sdk.Api.Models.Products.ProductSetSkuAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetSkuAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction SetTaxCategory(Action<commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.Products.ProductTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Products.ProductUnpublishAction Unpublish(Action<commercetools.Sdk.Api.Models.Products.ProductUnpublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Products.ProductUnpublishAction();
            init?.Invoke(t);
            return t;
        }
    }
}
