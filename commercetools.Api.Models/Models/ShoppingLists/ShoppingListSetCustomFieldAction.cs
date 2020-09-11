using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListSetCustomFieldAction : ShoppingListUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
