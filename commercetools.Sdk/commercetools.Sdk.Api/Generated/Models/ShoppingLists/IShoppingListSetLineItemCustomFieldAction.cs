using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction))]
    public partial interface IShoppingListSetLineItemCustomFieldAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
