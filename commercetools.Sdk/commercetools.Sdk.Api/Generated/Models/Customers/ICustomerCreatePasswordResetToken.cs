using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerCreatePasswordResetToken))]
    public partial interface ICustomerCreatePasswordResetToken
    {
        string Email { get; set; }

        long? TtlMinutes { get; set; }

    }
}
