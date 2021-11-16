using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetKeyAction))]
    public partial interface IShoppingListSetKeyAction : IShoppingListUpdateAction
    {
        string Key { get; set;}
    }
}
