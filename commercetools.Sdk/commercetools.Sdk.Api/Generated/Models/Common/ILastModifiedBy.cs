using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.LastModifiedBy))]
    public partial interface ILastModifiedBy : IClientLogging
    {
        new string ClientId { get; set; }

        new string ExternalUserId { get; set; }

        new ICustomerReference Customer { get; set; }

        new string AnonymousId { get; set; }

        IAttribution AttributedTo { get; set; }

        new ICustomerReference Associate { get; set; }

    }
}
