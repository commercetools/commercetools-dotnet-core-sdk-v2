using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetTextLineItemCustomFieldAction))]
    public partial interface IShoppingListSetTextLineItemCustomFieldAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
