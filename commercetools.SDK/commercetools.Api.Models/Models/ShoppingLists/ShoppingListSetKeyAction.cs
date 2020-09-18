using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setKey")]
    public class ShoppingListSetKeyAction : ShoppingListUpdateAction
    {
        public string Key { get; set;}
    }
}
