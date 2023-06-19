using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction))]
    public partial interface IShoppingListSetTextLineItemCustomFieldAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
