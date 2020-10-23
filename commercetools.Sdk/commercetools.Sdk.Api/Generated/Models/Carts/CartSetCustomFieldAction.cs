using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartSetCustomFieldAction : ICartSetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CartSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
