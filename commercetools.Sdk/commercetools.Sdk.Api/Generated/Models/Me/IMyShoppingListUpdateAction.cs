using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Api.Models.Me.MyShoppingListAddLineItemAction))]
    [SubTypeDiscriminator("addTextLineItem", typeof(commercetools.Api.Models.Me.MyShoppingListAddTextLineItemAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemsOrder", typeof(commercetools.Api.Models.Me.MyShoppingListChangeLineItemsOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.Me.MyShoppingListChangeNameAction))]
    [SubTypeDiscriminator("changeTextLineItemName", typeof(commercetools.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction))]
    [SubTypeDiscriminator("changeTextLineItemQuantity", typeof(commercetools.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTextLineItemsOrder", typeof(commercetools.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Api.Models.Me.MyShoppingListRemoveLineItemAction))]
    [SubTypeDiscriminator("removeTextLineItem", typeof(commercetools.Api.Models.Me.MyShoppingListRemoveTextLineItemAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Me.MyShoppingListSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Me.MyShoppingListSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.Me.MyShoppingListSetDescriptionAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Api.Models.Me.MyShoppingListSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Api.Models.Me.MyShoppingListSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setTextLineItemCustomField", typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setTextLineItemCustomType", typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setTextLineItemDescription", typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IMyShoppingListUpdateAction 
    {
        string Action { get; set;}
    }
}
