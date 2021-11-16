using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListRemoveTextLineItemAction))]
    public partial interface IShoppingListRemoveTextLineItemAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long? Quantity { get; set; }
    }
}
