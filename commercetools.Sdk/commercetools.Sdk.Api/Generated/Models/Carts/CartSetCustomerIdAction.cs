using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetCustomerIdAction : ICartSetCustomerIdAction
    {
        public string Action { get; set;}
        
        public string CustomerId { get; set;}
        public CartSetCustomerIdAction()
        { 
           this.Action = "setCustomerId";
        }
    }
}
