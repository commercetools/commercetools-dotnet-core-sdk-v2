using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Categories.CategoryUpdateAction))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Api.Models.Categories.CategoryAddAssetAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Api.Models.Categories.CategoryChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Api.Models.Categories.CategoryChangeAssetOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Categories.CategoryChangeNameAction))]
    [SubTypeDiscriminator("changeOrderHint", typeof(commercetools.Api.Models.Categories.CategoryChangeOrderHintAction))]
    [SubTypeDiscriminator("changeParent", typeof(commercetools.Api.Models.Categories.CategoryChangeParentAction))]
    [SubTypeDiscriminator("changeSlug", typeof(commercetools.Api.Models.Categories.CategoryChangeSlugAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Api.Models.Categories.CategoryRemoveAssetAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Api.Models.Categories.CategorySetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Api.Models.Categories.CategorySetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Api.Models.Categories.CategorySetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Api.Models.Categories.CategorySetAssetKeyAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Api.Models.Categories.CategorySetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Api.Models.Categories.CategorySetAssetTagsAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Categories.CategorySetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Categories.CategorySetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.Categories.CategorySetDescriptionAction))]
    [SubTypeDiscriminator("setExternalId", typeof(commercetools.Api.Models.Categories.CategorySetExternalIdAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Categories.CategorySetKeyAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Api.Models.Categories.CategorySetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Api.Models.Categories.CategorySetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Api.Models.Categories.CategorySetMetaTitleAction))]
    public partial interface ICategoryUpdateAction
    {
        string Action { get; set; }
    }
}
