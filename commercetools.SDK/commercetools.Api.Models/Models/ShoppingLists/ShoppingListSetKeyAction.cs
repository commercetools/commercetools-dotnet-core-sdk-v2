using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setKey")]
    public partial class ShoppingListSetKeyAction : ShoppingListUpdateAction
    {
        public string Key { get; set;}
        public ShoppingListSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
