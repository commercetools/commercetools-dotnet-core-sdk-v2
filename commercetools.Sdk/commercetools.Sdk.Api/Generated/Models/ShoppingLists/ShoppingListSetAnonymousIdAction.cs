using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setAnonymousId")]
    public partial class ShoppingListSetAnonymousIdAction : ShoppingListUpdateAction
    {
        public string AnonymousId { get; set;}
        public ShoppingListSetAnonymousIdAction()
        { 
           this.Action = "setAnonymousId";
        }
    }
}
