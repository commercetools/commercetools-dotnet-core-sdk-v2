using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public  partial class ShoppingListSetKeyAction : IShoppingListSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public ShoppingListSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
