using commercetools.Api.Models.Categorys;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Categorys
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(CategoryAddAssetAction), "addAsset")]
    [JsonSubtypes.KnownSubType(typeof(CategoryChangeAssetNameAction), "changeAssetName")]
    [JsonSubtypes.KnownSubType(typeof(CategoryChangeAssetOrderAction), "changeAssetOrder")]
    [JsonSubtypes.KnownSubType(typeof(CategoryChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(CategoryChangeOrderHintAction), "changeOrderHint")]
    [JsonSubtypes.KnownSubType(typeof(CategoryChangeParentAction), "changeParent")]
    [JsonSubtypes.KnownSubType(typeof(CategoryChangeSlugAction), "changeSlug")]
    [JsonSubtypes.KnownSubType(typeof(CategoryRemoveAssetAction), "removeAsset")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetAssetCustomFieldAction), "setAssetCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetAssetCustomTypeAction), "setAssetCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetAssetDescriptionAction), "setAssetDescription")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetAssetKeyAction), "setAssetKey")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetAssetSourcesAction), "setAssetSources")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetAssetTagsAction), "setAssetTags")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetExternalIdAction), "setExternalId")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetMetaDescriptionAction), "setMetaDescription")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetMetaKeywordsAction), "setMetaKeywords")]
    [JsonSubtypes.KnownSubType(typeof(CategorySetMetaTitleAction), "setMetaTitle")]
    public abstract class CategoryUpdateAction 
    {
        public string Action { get; set;}
    }
}
