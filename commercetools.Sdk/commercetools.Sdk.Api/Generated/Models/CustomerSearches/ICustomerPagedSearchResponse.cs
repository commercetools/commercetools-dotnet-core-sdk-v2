using commercetools.Sdk.Api.Models.CustomerSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerSearches.CustomerPagedSearchResponse))]
    public partial interface ICustomerPagedSearchResponse
    {
        long Total { get; set; }

        int Limit { get; set; }

        int Offset { get; set; }

        IList<ICustomerSearchResult> Results { get; set; }
        IEnumerable<ICustomerSearchResult> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
