using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListRemoveLineItemAction))]
    public partial interface IShoppingListRemoveLineItemAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        long? Quantity { get; set; }

    }
}
