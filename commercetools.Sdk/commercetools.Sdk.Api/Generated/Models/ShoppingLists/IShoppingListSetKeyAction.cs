using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetKeyAction))]
    public partial interface IShoppingListSetKeyAction : IShoppingListUpdateAction
    {
        string Key { get; set; }

    }
}
