using commercetools.Api.Models.ShoppingLists;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListAddLineItemAction), "addLineItem")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListAddTextLineItemAction), "addTextLineItem")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListChangeLineItemQuantityAction), "changeLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListChangeLineItemsOrderAction), "changeLineItemsOrder")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListChangeTextLineItemNameAction), "changeTextLineItemName")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListChangeTextLineItemQuantityAction), "changeTextLineItemQuantity")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListChangeTextLineItemsOrderAction), "changeTextLineItemsOrder")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListRemoveLineItemAction), "removeLineItem")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListRemoveTextLineItemAction), "removeTextLineItem")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetAnonymousIdAction), "setAnonymousId")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetCustomerAction), "setCustomer")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetDeleteDaysAfterLastModificationAction), "setDeleteDaysAfterLastModification")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetDescriptionAction), "setDescription")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetLineItemCustomFieldAction), "setLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetLineItemCustomTypeAction), "setLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetSlugAction), "setSlug")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetTextLineItemCustomFieldAction), "setTextLineItemCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetTextLineItemCustomTypeAction), "setTextLineItemCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ShoppingListSetTextLineItemDescriptionAction), "setTextLineItemDescription")]
    public abstract class ShoppingListUpdateAction 
    {
        public string Action { get; set;}
    }
}
