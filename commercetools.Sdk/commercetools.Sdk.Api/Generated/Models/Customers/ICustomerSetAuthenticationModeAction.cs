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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetAuthenticationModeAction))]
    public partial interface ICustomerSetAuthenticationModeAction : ICustomerUpdateAction
    {
        IAuthenticationMode AuthMode { get; set; }

        string Password { get; set; }

    }
}
