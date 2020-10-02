using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setCustomField")]
    public partial class ShoppingListSetCustomFieldAction : ShoppingListUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ShoppingListSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
