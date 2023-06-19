using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemQuantityAction))]
    public partial interface IShoppingListChangeTextLineItemQuantityAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long Quantity { get; set; }

    }
}
