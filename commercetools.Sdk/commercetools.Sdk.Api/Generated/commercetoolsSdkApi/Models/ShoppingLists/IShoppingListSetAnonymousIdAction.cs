using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetAnonymousIdAction))]
    public partial interface IShoppingListSetAnonymousIdAction : IShoppingListUpdateAction
    {
        string AnonymousId { get; set; }

    }
}
