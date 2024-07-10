using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.MyCustomerChangePassword))]
    public partial interface IMyCustomerChangePassword
    {
        long Version { get; set; }

        string CurrentPassword { get; set; }

        string NewPassword { get; set; }

    }
}
