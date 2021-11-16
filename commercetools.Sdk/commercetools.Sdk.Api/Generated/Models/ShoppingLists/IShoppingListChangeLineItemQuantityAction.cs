using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction))]
    public partial interface IShoppingListChangeLineItemQuantityAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set;}
        
        long Quantity { get; set;}
    }
}
