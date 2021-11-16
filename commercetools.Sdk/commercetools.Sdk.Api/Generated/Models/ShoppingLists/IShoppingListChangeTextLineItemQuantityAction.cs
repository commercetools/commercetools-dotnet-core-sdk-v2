using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction))]
    public partial interface IShoppingListChangeTextLineItemQuantityAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        long Quantity { get; set;}
    }
}
