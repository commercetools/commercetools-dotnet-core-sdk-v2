using commercetools.Api.Generated.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingListUpdate 
    {
        long Version { get; set;}
        
        List<IShoppingListUpdateAction> Actions { get; set;}
    }
}
