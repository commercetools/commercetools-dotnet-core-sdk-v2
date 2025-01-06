using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemRemovedMessagePayload))]
    public partial interface IShoppingListLineItemRemovedMessagePayload : IShoppingListMessagePayload
    {
        IShoppingListLineItem LineItem { get; set; }

    }
}
