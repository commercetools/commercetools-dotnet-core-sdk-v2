using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction))]
    public partial interface IShoppingListSetCustomFieldAction : IShoppingListUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
