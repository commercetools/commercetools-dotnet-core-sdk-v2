using commercetools.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetStoreAction))]
    public partial interface IShoppingListSetStoreAction : IShoppingListUpdateAction
    {
        IStoreResourceIdentifier Store { get; set;}
    }
}
