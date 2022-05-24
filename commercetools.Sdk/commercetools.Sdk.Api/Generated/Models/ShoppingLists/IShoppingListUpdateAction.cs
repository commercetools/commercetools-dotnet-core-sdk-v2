using commercetools.Base.CustomAttributes;


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
    }
}
