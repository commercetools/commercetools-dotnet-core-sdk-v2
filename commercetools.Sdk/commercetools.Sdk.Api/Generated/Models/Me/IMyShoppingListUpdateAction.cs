using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListUpdateAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListAddLineItemAction))]
    [SubTypeDiscriminator("addTextLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListAddTextLineItemAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemsOrder", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemsOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeNameAction))]
    [SubTypeDiscriminator("changeTextLineItemName", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction))]
    [SubTypeDiscriminator("changeTextLineItemQuantity", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTextLineItemsOrder", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveLineItemAction))]
    [SubTypeDiscriminator("removeTextLineItem", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveTextLineItemAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetDescriptionAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setTextLineItemCustomField", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setTextLineItemCustomType", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setTextLineItemDescription", typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IMyShoppingListUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyShoppingListAddLineItemAction AddLineItem(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListAddLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListAddLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListAddTextLineItemAction AddTextLineItem(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListAddTextLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListAddTextLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction ChangeLineItemQuantity(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemsOrderAction ChangeLineItemsOrder(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemsOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemsOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction ChangeTextLineItemName(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction ChangeTextLineItemQuantity(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction ChangeTextLineItemsOrder(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemsOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveLineItemAction RemoveLineItem(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveTextLineItemAction RemoveTextLineItem(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveTextLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveTextLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction SetDeleteDaysAfterLastModification(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetDeleteDaysAfterLastModificationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomFieldAction SetLineItemCustomField(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomTypeAction SetLineItemCustomType(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomFieldAction SetTextLineItemCustomField(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction SetTextLineItemCustomType(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction SetTextLineItemDescription(Action<commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyShoppingListSetTextLineItemDescriptionAction();
            init?.Invoke(t);
            return t;
        }
    }
}
