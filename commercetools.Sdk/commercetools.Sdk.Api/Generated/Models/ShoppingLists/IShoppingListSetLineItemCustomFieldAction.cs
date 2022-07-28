using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetLineItemCustomFieldAction))]
    public partial interface IShoppingListSetLineItemCustomFieldAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
