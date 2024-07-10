using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerSearches.CustomerSearchRequest))]
    public partial interface ICustomerSearchRequest
    {
        ISearchQuery Query { get; set; }

        IList<ISearchSorting> Sort { get; set; }
        IEnumerable<ISearchSorting> SortEnumerable { set => Sort = value.ToList(); }


        int? Limit { get; set; }

        int? Offset { get; set; }

    }
}
