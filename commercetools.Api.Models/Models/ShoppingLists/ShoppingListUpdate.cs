using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListUpdate 
    {
        public long Version { get; set;}
        
        public List<ShoppingListUpdateAction> Actions { get; set;}
    }
}
