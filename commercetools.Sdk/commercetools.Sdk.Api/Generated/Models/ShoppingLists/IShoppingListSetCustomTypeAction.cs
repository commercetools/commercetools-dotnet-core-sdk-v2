using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetCustomTypeAction))]
    public interface IShoppingListSetCustomTypeAction : IShoppingListUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
