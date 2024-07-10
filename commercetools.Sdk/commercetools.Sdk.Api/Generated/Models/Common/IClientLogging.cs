using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.ClientLogging))]
    public partial interface IClientLogging
    {
        string ClientId { get; set; }

        string ExternalUserId { get; set; }

        ICustomerReference Customer { get; set; }

        string AnonymousId { get; set; }

        ICustomerReference Associate { get; set; }

    }
}
