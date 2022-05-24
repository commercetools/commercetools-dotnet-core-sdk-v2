using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Categories.CategoryUpdateAction))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Sdk.Api.Models.Categories.CategoryAddAssetAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeNameAction))]
    [SubTypeDiscriminator("changeOrderHint", typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeOrderHintAction))]
    [SubTypeDiscriminator("changeParent", typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeParentAction))]
    [SubTypeDiscriminator("changeSlug", typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeSlugAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Sdk.Api.Models.Categories.CategoryRemoveAssetAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetKeyAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetAssetTagsAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetDescriptionAction))]
    [SubTypeDiscriminator("setExternalId", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetExternalIdAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetKeyAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Sdk.Api.Models.Categories.CategorySetMetaTitleAction))]
    public partial interface ICategoryUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<ICategoryUpdateAction>
    {
        new string Action { get; set; }
    }
}
