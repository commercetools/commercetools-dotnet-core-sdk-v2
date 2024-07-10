using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerSearches.CustomerSearchResult))]
    public partial interface ICustomerSearchResult
    {
        string Id { get; set; }

        decimal Relevance { get; set; }

    }
}
