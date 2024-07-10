using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUpdateAction))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddAssetAction))]
    [SubTypeDiscriminator("addExternalImage", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddExternalImageAction))]
    [SubTypeDiscriminator("addVariant", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddVariantAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetOrderAction))]
    [SubTypeDiscriminator("moveImageToPosition", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringMoveImageToPositionAction))]
    [SubTypeDiscriminator("publish", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveAssetAction))]
    [SubTypeDiscriminator("removeImage", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveImageAction))]
    [SubTypeDiscriminator("removeVariant", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveVariantAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetKeyAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetTagsAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction))]
    [SubTypeDiscriminator("setImageLabel", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetImageLabelAction))]
    [SubTypeDiscriminator("setImages", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetExternalImagesAction))]
    [SubTypeDiscriminator("setMetaAttributes", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction))]
    [SubTypeDiscriminator("setSlug", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction))]
    [SubTypeDiscriminator("unpublish", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction))]
    public partial interface IProductTailoringUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddAssetAction AddAsset(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddExternalImageAction AddExternalImage(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddExternalImageAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddExternalImageAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddVariantAction AddVariant(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddVariantAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAddVariantAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetNameAction ChangeAssetName(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetOrderAction ChangeAssetOrder(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringChangeAssetOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringMoveImageToPositionAction MoveImageToPosition(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringMoveImageToPositionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringMoveImageToPositionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction Publish(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveAssetAction RemoveAsset(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveImageAction RemoveImage(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveImageAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveImageAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveVariantAction RemoveVariant(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveVariantAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringRemoveVariantAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomFieldAction SetAssetCustomField(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomTypeAction SetAssetCustomType(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetDescriptionAction SetAssetDescription(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetKeyAction SetAssetKey(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetSourcesAction SetAssetSources(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetSourcesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetSourcesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetTagsAction SetAssetTags(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetTagsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetAssetTagsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetImageLabelAction SetImageLabel(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetImageLabelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetImageLabelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetExternalImagesAction SetImages(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetExternalImagesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetExternalImagesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction SetMetaAttributes(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction SetMetaDescription(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction SetMetaKeywords(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction SetMetaTitle(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction SetName(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction SetSlug(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction Unpublish(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction();
            init?.Invoke(t);
            return t;
        }
    }
}
