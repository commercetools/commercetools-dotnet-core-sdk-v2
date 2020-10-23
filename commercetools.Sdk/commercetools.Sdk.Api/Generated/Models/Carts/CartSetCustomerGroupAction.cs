using commercetools.Api.Models.Carts;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartSetCustomerGroupAction : ICartSetCustomerGroupAction
    {
        public string Action { get; set;}
        
        public ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        public CartSetCustomerGroupAction()
        { 
           this.Action = "setCustomerGroup";
        }
    }
}
