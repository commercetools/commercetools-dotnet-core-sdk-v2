using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddStoreAction))]
    public partial interface ICustomerAddStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
