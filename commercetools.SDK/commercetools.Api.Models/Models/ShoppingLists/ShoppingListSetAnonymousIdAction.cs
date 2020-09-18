using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setAnonymousId")]
    public class ShoppingListSetAnonymousIdAction : ShoppingListUpdateAction
    {
        public string AnonymousId { get; set;}
    }
}
