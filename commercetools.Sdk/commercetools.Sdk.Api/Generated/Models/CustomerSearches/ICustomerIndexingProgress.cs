using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerSearches.CustomerIndexingProgress))]
    public partial interface ICustomerIndexingProgress
    {
        int Indexed { get; set; }

        int Failed { get; set; }

        int EstimatedTotal { get; set; }

    }
}
