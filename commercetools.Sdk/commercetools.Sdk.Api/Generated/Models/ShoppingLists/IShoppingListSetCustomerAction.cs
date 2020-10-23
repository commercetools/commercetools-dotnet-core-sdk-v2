using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetCustomerAction))]
    public interface IShoppingListSetCustomerAction : IShoppingListUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set;}
    }
}
