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
    }
}
