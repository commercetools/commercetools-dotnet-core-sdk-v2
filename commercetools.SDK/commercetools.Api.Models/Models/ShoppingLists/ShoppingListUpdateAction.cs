using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [Discriminator(nameof(Action))]
    public abstract class ShoppingListUpdateAction 
    {
        public string Action { get; set;}
    }
}
