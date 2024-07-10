using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetCustomerAction))]
    public partial interface IShoppingListSetCustomerAction : IShoppingListUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
