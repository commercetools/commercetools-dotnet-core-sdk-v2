using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Api.Models.Products.ProductAddAssetAction))]
    [SubTypeDiscriminator("addExternalImage", typeof(commercetools.Api.Models.Products.ProductAddExternalImageAction))]
    [SubTypeDiscriminator("addPrice", typeof(commercetools.Api.Models.Products.ProductAddPriceAction))]
    [SubTypeDiscriminator("addToCategory", typeof(commercetools.Api.Models.Products.ProductAddToCategoryAction))]
    [SubTypeDiscriminator("addVariant", typeof(commercetools.Api.Models.Products.ProductAddVariantAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Api.Models.Products.ProductChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Api.Models.Products.ProductChangeAssetOrderAction))]
    [SubTypeDiscriminator("changeMasterVariant", typeof(commercetools.Api.Models.Products.ProductChangeMasterVariantAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Products.ProductChangeNameAction))]
    [SubTypeDiscriminator("changePrice", typeof(commercetools.Api.Models.Products.ProductChangePriceAction))]
    [SubTypeDiscriminator("changeSlug", typeof(commercetools.Api.Models.Products.ProductChangeSlugAction))]
    [SubTypeDiscriminator("legacySetSku", typeof(commercetools.Api.Models.Products.ProductLegacySetSkuAction))]
    [SubTypeDiscriminator("moveImageToPosition", typeof(commercetools.Api.Models.Products.ProductMoveImageToPositionAction))]
    [SubTypeDiscriminator("publish", typeof(commercetools.Api.Models.Products.ProductPublishAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Api.Models.Products.ProductRemoveAssetAction))]
    [SubTypeDiscriminator("removeFromCategory", typeof(commercetools.Api.Models.Products.ProductRemoveFromCategoryAction))]
    [SubTypeDiscriminator("removeImage", typeof(commercetools.Api.Models.Products.ProductRemoveImageAction))]
    [SubTypeDiscriminator("removePrice", typeof(commercetools.Api.Models.Products.ProductRemovePriceAction))]
    [SubTypeDiscriminator("removeVariant", typeof(commercetools.Api.Models.Products.ProductRemoveVariantAction))]
    [SubTypeDiscriminator("revertStagedChanges", typeof(commercetools.Api.Models.Products.ProductRevertStagedChangesAction))]
    [SubTypeDiscriminator("revertStagedVariantChanges", typeof(commercetools.Api.Models.Products.ProductRevertStagedVariantChangesAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Api.Models.Products.ProductSetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Api.Models.Products.ProductSetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Api.Models.Products.ProductSetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Api.Models.Products.ProductSetAssetKeyAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Api.Models.Products.ProductSetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Api.Models.Products.ProductSetAssetTagsAction))]
    [SubTypeDiscriminator("setAttribute", typeof(commercetools.Api.Models.Products.ProductSetAttributeAction))]
    [SubTypeDiscriminator("setAttributeInAllVariants", typeof(commercetools.Api.Models.Products.ProductSetAttributeInAllVariantsAction))]
    [SubTypeDiscriminator("setCategoryOrderHint", typeof(commercetools.Api.Models.Products.ProductSetCategoryOrderHintAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.Products.ProductSetDescriptionAction))]
    [SubTypeDiscriminator("setDiscountedPrice", typeof(commercetools.Api.Models.Products.ProductSetDiscountedPriceAction))]
    [SubTypeDiscriminator("setImageLabel", typeof(commercetools.Api.Models.Products.ProductSetImageLabelAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Products.ProductSetKeyAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Api.Models.Products.ProductSetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Api.Models.Products.ProductSetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Api.Models.Products.ProductSetMetaTitleAction))]
    [SubTypeDiscriminator("setPrices", typeof(commercetools.Api.Models.Products.ProductSetPricesAction))]
    [SubTypeDiscriminator("setProductPriceCustomField", typeof(commercetools.Api.Models.Products.ProductSetProductPriceCustomFieldAction))]
    [SubTypeDiscriminator("setProductPriceCustomType", typeof(commercetools.Api.Models.Products.ProductSetProductPriceCustomTypeAction))]
    [SubTypeDiscriminator("setProductVariantKey", typeof(commercetools.Api.Models.Products.ProductSetProductVariantKeyAction))]
    [SubTypeDiscriminator("setSearchKeywords", typeof(commercetools.Api.Models.Products.ProductSetSearchKeywordsAction))]
    [SubTypeDiscriminator("setSku", typeof(commercetools.Api.Models.Products.ProductSetSkuAction))]
    [SubTypeDiscriminator("setTaxCategory", typeof(commercetools.Api.Models.Products.ProductSetTaxCategoryAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Api.Models.Products.ProductTransitionStateAction))]
    [SubTypeDiscriminator("unpublish", typeof(commercetools.Api.Models.Products.ProductUnpublishAction))]
    public interface IProductUpdateAction 
    {
        string Action { get; set;}
    }
}
