using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Variants.VariantUpdateAction))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Sdk.Api.Models.Variants.VariantAddAssetAction))]
    [SubTypeDiscriminator("addExternalImage", typeof(commercetools.Sdk.Api.Models.Variants.VariantAddExternalImageAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Sdk.Api.Models.Variants.VariantChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Sdk.Api.Models.Variants.VariantChangeAssetOrderAction))]
    [SubTypeDiscriminator("publish", typeof(commercetools.Sdk.Api.Models.Variants.VariantPublishAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Sdk.Api.Models.Variants.VariantRemoveAssetAction))]
    [SubTypeDiscriminator("removeImage", typeof(commercetools.Sdk.Api.Models.Variants.VariantRemoveImageAction))]
    [SubTypeDiscriminator("removeStagedChanges", typeof(commercetools.Sdk.Api.Models.Variants.VariantRemoveStagedChangesAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetKeyAction))]
    [SubTypeDiscriminator("setAssets", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetsAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAssetTagsAction))]
    [SubTypeDiscriminator("setAttribute", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAttributeAction))]
    [SubTypeDiscriminator("setAttributes", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAttributesAction))]
    [SubTypeDiscriminator("setImages", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetImagesAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetKeyAction))]
    [SubTypeDiscriminator("setSku", typeof(commercetools.Sdk.Api.Models.Variants.VariantSetSkuAction))]
    [SubTypeDiscriminator("unpublish", typeof(commercetools.Sdk.Api.Models.Variants.VariantUnpublishAction))]
    public partial interface IVariantUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Variants.VariantAddAssetAction AddAsset(Action<commercetools.Sdk.Api.Models.Variants.VariantAddAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantAddAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantAddExternalImageAction AddExternalImage(Action<commercetools.Sdk.Api.Models.Variants.VariantAddExternalImageAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantAddExternalImageAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantChangeAssetNameAction ChangeAssetName(Action<commercetools.Sdk.Api.Models.Variants.VariantChangeAssetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantChangeAssetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantChangeAssetOrderAction ChangeAssetOrder(Action<commercetools.Sdk.Api.Models.Variants.VariantChangeAssetOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantChangeAssetOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantPublishAction Publish(Action<commercetools.Sdk.Api.Models.Variants.VariantPublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantPublishAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantRemoveAssetAction RemoveAsset(Action<commercetools.Sdk.Api.Models.Variants.VariantRemoveAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantRemoveAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantRemoveImageAction RemoveImage(Action<commercetools.Sdk.Api.Models.Variants.VariantRemoveImageAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantRemoveImageAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantRemoveStagedChangesAction RemoveStagedChanges(Action<commercetools.Sdk.Api.Models.Variants.VariantRemoveStagedChangesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantRemoveStagedChangesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomFieldAction SetAssetCustomField(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomTypeAction SetAssetCustomType(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetDescriptionAction SetAssetDescription(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetKeyAction SetAssetKey(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetsAction SetAssets(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetSourcesAction SetAssetSources(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetSourcesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetSourcesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAssetTagsAction SetAssetTags(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAssetTagsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAssetTagsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAttributeAction SetAttribute(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAttributeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAttributeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetAttributesAction SetAttributes(Action<commercetools.Sdk.Api.Models.Variants.VariantSetAttributesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetAttributesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetImagesAction SetImages(Action<commercetools.Sdk.Api.Models.Variants.VariantSetImagesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetImagesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Variants.VariantSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantSetSkuAction SetSku(Action<commercetools.Sdk.Api.Models.Variants.VariantSetSkuAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantSetSkuAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Variants.VariantUnpublishAction Unpublish(Action<commercetools.Sdk.Api.Models.Variants.VariantUnpublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Variants.VariantUnpublishAction();
            init?.Invoke(t);
            return t;
        }
    }
}
