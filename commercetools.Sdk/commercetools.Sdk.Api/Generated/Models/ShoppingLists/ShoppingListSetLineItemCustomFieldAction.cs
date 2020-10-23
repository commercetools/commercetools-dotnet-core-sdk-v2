using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public  partial class ShoppingListSetLineItemCustomFieldAction : IShoppingListSetLineItemCustomFieldAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ShoppingListSetLineItemCustomFieldAction()
        { 
           this.Action = "setLineItemCustomField";
        }
    }
}
