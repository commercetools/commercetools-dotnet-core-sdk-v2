using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setCustomField")]
    public class ShoppingListSetCustomFieldAction : ShoppingListUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
