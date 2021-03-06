using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetCustomFieldAction))]
    public partial interface IShoppingListSetCustomFieldAction : IShoppingListUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
