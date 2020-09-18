using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListUpdate 
    {
        public long Version { get; set;}
        
        public List<ShoppingListUpdateAction> Actions { get; set;}
    }
}
