using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyShoppingListSetCustomFieldAction : MyShoppingListUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
