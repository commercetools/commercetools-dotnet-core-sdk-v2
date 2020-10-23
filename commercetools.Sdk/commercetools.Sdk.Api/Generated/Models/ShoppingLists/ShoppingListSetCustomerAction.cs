using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public  partial class ShoppingListSetCustomerAction : IShoppingListSetCustomerAction
    {
        public string Action { get; set;}
        
        public ICustomerResourceIdentifier Customer { get; set;}
        public ShoppingListSetCustomerAction()
        { 
           this.Action = "setCustomer";
        }
    }
}
