using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListUpdateAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddLineItemAction))]
    [SubTypeDiscriminator("addTextLineItem", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddTextLineItemAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemsOrder", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeNameAction))]
    [SubTypeDiscriminator("changeTextLineItemName", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction))]
    [SubTypeDiscriminator("changeTextLineItemQuantity", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction))]
    [SubTypeDiscriminator("changeTextLineItemsOrder", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction))]
    [SubTypeDiscriminator("removeTextLineItem", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction))]
    [SubTypeDiscriminator("setAnonymousId", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetAnonymousIdAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomerAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeleteDaysAfterLastModification", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetKeyAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setSlug", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetSlugAction))]
    [SubTypeDiscriminator("setStore", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetStoreAction))]
    [SubTypeDiscriminator("setTextLineItemCustomField", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setTextLineItemCustomType", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setTextLineItemDescription", typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IShoppingListUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IShoppingListUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddLineItemAction AddLineItem(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddTextLineItemAction AddTextLineItem(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddTextLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddTextLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction ChangeLineItemQuantity(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction ChangeLineItemsOrder(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction ChangeTextLineItemName(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction ChangeTextLineItemQuantity(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction ChangeTextLineItemsOrder(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction RemoveLineItem(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction RemoveTextLineItem(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetAnonymousIdAction SetAnonymousId(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetAnonymousIdAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetAnonymousIdAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomerAction SetCustomer(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomerAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomerAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction SetDeleteDaysAfterLastModification(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction SetLineItemCustomField(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomTypeAction SetLineItemCustomType(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetSlugAction SetSlug(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetSlugAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetSlugAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetStoreAction SetStore(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction SetTextLineItemCustomField(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction SetTextLineItemCustomType(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction SetTextLineItemDescription(Action<commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction();
            init?.Invoke(t);
            return t;
        }
    }
}
