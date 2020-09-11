using commercetools.Api.Models.Me;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListAddLineItemAction), "addLineItem")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListAddTextLineItemAction), "addTextLineItem")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListChangeLineItemQuantityAction), "changeLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListChangeLineItemsOrderAction), "changeLineItemsOrder")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListChangeTextLineItemNameAction), "changeTextLineItemName")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListChangeTextLineItemQuantityAction), "changeTextLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListChangeTextLineItemsOrderAction), "changeTextLineItemsOrder")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListRemoveLineItemAction), "removeLineItem")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListRemoveTextLineItemAction), "removeTextLineItem")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetDeleteDaysAfterLastModificationAction), "setDeleteDaysAfterLastModification")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetLineItemCustomFieldAction), "setLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetLineItemCustomTypeAction), "setLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetTextLineItemCustomFieldAction), "setTextLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetTextLineItemCustomTypeAction), "setTextLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(MyShoppingListSetTextLineItemDescriptionAction), "setTextLineItemDescription")]
    public abstract class MyShoppingListUpdateAction 
    {
        public string Action { get; set;}
    }
}
