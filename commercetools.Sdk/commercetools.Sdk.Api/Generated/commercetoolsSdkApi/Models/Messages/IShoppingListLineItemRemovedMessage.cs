using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemRemovedMessage))]
    public partial interface IShoppingListLineItemRemovedMessage : IShoppingListMessage
    {
        IShoppingListLineItem LineItem { get; set; }

    }
}
