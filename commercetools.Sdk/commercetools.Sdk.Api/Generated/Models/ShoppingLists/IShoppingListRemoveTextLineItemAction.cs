using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction))]
    public partial interface IShoppingListRemoveTextLineItemAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long? Quantity { get; set; }

    }
}
