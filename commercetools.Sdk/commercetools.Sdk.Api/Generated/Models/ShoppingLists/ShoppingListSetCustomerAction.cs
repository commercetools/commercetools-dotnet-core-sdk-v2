using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setCustomer")]
    public partial class ShoppingListSetCustomerAction : ShoppingListUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
        public ShoppingListSetCustomerAction()
        { 
           this.Action = "setCustomer";
        }
    }
}
