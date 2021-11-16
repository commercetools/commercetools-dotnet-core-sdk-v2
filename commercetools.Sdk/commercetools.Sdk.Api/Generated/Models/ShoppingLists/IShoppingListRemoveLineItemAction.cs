using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction))]
    public partial interface IShoppingListRemoveLineItemAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set;}
        
        long? Quantity { get; set;}
    }
}
