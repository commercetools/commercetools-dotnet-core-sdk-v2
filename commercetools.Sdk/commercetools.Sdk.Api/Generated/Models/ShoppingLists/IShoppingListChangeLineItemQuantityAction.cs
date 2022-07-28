using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction))]
    public partial interface IShoppingListChangeLineItemQuantityAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        long Quantity { get; set; }

    }
}
