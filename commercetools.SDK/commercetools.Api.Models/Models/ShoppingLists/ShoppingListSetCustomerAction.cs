using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setCustomer")]
    public class ShoppingListSetCustomerAction : ShoppingListUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
    }
}
