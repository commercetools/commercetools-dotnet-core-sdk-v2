using commercetools.Sdk.Api.Models.ShoppingLists;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ShoppingListLineItemAddedMessagePayload))]
    public partial interface IShoppingListLineItemAddedMessagePayload : IShoppingListMessagePayload
    {
        IShoppingListLineItem LineItem { get; set; }

    }
}
