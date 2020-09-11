using commercetools.Api.Models.Products;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ProductAddAssetAction), "addAsset")]
    [JsonSubtypes.KnownSubType(typeof(ProductAddExternalImageAction), "addExternalImage")]
    [JsonSubtypes.KnownSubType(typeof(ProductAddPriceAction), "addPrice")]
    [JsonSubtypes.KnownSubType(typeof(ProductAddToCategoryAction), "addToCategory")]
    [JsonSubtypes.KnownSubType(typeof(ProductAddVariantAction), "addVariant")]
    [JsonSubtypes.KnownSubType(typeof(ProductChangeAssetNameAction), "changeAssetName")]
    [JsonSubtypes.KnownSubType(typeof(ProductChangeAssetOrderAction), "changeAssetOrder")]
    [JsonSubtypes.KnownSubType(typeof(ProductChangeMasterVariantAction), "changeMasterVariant")]
    [JsonSubtypes.KnownSubType(typeof(ProductChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ProductChangePriceAction), "changePrice")]
    [JsonSubtypes.KnownSubType(typeof(ProductChangeSlugAction), "changeSlug")]
    [JsonSubtypes.KnownSubType(typeof(ProductLegacySetSkuAction), "legacySetSku")]
    [JsonSubtypes.KnownSubType(typeof(ProductMoveImageToPositionAction), "moveImageToPosition")]
    [JsonSubtypes.KnownSubType(typeof(ProductPublishAction), "publish")]
    [JsonSubtypes.KnownSubType(typeof(ProductRemoveAssetAction), "removeAsset")]
    [JsonSubtypes.KnownSubType(typeof(ProductRemoveFromCategoryAction), "removeFromCategory")]
    [JsonSubtypes.KnownSubType(typeof(ProductRemoveImageAction), "removeImage")]
    [JsonSubtypes.KnownSubType(typeof(ProductRemovePriceAction), "removePrice")]
    [JsonSubtypes.KnownSubType(typeof(ProductRemoveVariantAction), "removeVariant")]
    [JsonSubtypes.KnownSubType(typeof(ProductRevertStagedChangesAction), "revertStagedChanges")]
    [JsonSubtypes.KnownSubType(typeof(ProductRevertStagedVariantChangesAction), "revertStagedVariantChanges")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAssetCustomFieldAction), "setAssetCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAssetCustomTypeAction), "setAssetCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAssetDescriptionAction), "setAssetDescription")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAssetKeyAction), "setAssetKey")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAssetSourcesAction), "setAssetSources")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAssetTagsAction), "setAssetTags")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAttributeAction), "setAttribute")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetAttributeInAllVariantsAction), "setAttributeInAllVariants")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetCategoryOrderHintAction), "setCategoryOrderHint")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetDiscountedPriceAction), "setDiscountedPrice")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetImageLabelAction), "setImageLabel")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetMetaDescriptionAction), "setMetaDescription")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetMetaKeywordsAction), "setMetaKeywords")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetMetaTitleAction), "setMetaTitle")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetPricesAction), "setPrices")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetProductPriceCustomFieldAction), "setProductPriceCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetProductPriceCustomTypeAction), "setProductPriceCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetProductVariantKeyAction), "setProductVariantKey")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetSearchKeywordsAction), "setSearchKeywords")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetSkuAction), "setSku")]
    [JsonSubtypes.KnownSubType(typeof(ProductSetTaxCategoryAction), "setTaxCategory")]
    [JsonSubtypes.KnownSubType(typeof(ProductTransitionStateAction), "transitionState")]
    [JsonSubtypes.KnownSubType(typeof(ProductUnpublishAction), "unpublish")]
    public abstract class ProductUpdateAction 
    {
        public string Action { get; set;}
    }
}
