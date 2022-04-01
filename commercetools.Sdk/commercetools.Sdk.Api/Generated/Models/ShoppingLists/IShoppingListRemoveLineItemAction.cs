using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction))]
    public partial interface IShoppingListRemoveLineItemAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        long? Quantity { get; set; }
    }
}
