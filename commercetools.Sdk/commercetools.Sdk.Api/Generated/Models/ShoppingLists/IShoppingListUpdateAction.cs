using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListUpdateAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListAddLineItemAction))]
    [SubTypeDiscriminator("addTextLineItem", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListAddTextLineItemAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemsOrder", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeNameAction))]
    [SubTypeDiscriminator("changeTextLineItemName", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction))]
    [SubTypeDiscriminator("changeTextLineItemQuantity", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTextLineItemsOrder", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction))]
    [SubTypeDiscriminator("removeTextLineItem", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetAnonymousIdAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetCustomerAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetKeyAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setSlug", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetSlugAction))]
    [SubTypeDiscriminator("setStore", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetStoreAction))]
    [SubTypeDiscriminator("setTextLineItemCustomField", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setTextLineItemCustomType", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setTextLineItemDescription", typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IShoppingListUpdateAction
    {
        string Action { get; set; }
    }
}
