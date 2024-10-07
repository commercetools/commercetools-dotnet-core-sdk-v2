using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetStoreAction))]
    public partial interface IShoppingListSetStoreAction : IShoppingListUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
