using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
    public partial interface ICategoryUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Categories.CategoryAddAssetAction AddAsset(Action<commercetools.Sdk.Api.Models.Categories.CategoryAddAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryAddAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetNameAction ChangeAssetName(Action<commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetOrderAction ChangeAssetOrder(Action<commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryChangeAssetOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Categories.CategoryChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryChangeOrderHintAction ChangeOrderHint(Action<commercetools.Sdk.Api.Models.Categories.CategoryChangeOrderHintAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryChangeOrderHintAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryChangeParentAction ChangeParent(Action<commercetools.Sdk.Api.Models.Categories.CategoryChangeParentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryChangeParentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryChangeSlugAction ChangeSlug(Action<commercetools.Sdk.Api.Models.Categories.CategoryChangeSlugAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryChangeSlugAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategoryRemoveAssetAction RemoveAsset(Action<commercetools.Sdk.Api.Models.Categories.CategoryRemoveAssetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategoryRemoveAssetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomFieldAction SetAssetCustomField(Action<commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomTypeAction SetAssetCustomType(Action<commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetAssetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetAssetDescriptionAction SetAssetDescription(Action<commercetools.Sdk.Api.Models.Categories.CategorySetAssetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetAssetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetAssetKeyAction SetAssetKey(Action<commercetools.Sdk.Api.Models.Categories.CategorySetAssetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetAssetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetAssetSourcesAction SetAssetSources(Action<commercetools.Sdk.Api.Models.Categories.CategorySetAssetSourcesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetAssetSourcesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetAssetTagsAction SetAssetTags(Action<commercetools.Sdk.Api.Models.Categories.CategorySetAssetTagsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetAssetTagsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Categories.CategorySetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Categories.CategorySetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.Categories.CategorySetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetExternalIdAction SetExternalId(Action<commercetools.Sdk.Api.Models.Categories.CategorySetExternalIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetExternalIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Categories.CategorySetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetMetaDescriptionAction SetMetaDescription(Action<commercetools.Sdk.Api.Models.Categories.CategorySetMetaDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetMetaDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetMetaKeywordsAction SetMetaKeywords(Action<commercetools.Sdk.Api.Models.Categories.CategorySetMetaKeywordsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetMetaKeywordsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Categories.CategorySetMetaTitleAction SetMetaTitle(Action<commercetools.Sdk.Api.Models.Categories.CategorySetMetaTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Categories.CategorySetMetaTitleAction();
            init?.Invoke(t);
            return t;
        }
    }
}
