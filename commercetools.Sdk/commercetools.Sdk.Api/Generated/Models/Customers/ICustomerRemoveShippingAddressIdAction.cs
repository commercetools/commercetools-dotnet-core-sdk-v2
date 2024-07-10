using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerRemoveShippingAddressIdAction))]
    public partial interface ICustomerRemoveShippingAddressIdAction : ICustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

    }
}
