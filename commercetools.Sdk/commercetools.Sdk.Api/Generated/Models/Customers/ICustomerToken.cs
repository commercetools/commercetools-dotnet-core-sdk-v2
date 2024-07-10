using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerToken))]
    public partial interface ICustomerToken
    {
        string Id { get; set; }

        string CustomerId { get; set; }

        string Value { get; set; }

        DateTime ExpiresAt { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime? LastModifiedAt { get; set; }

    }
}
