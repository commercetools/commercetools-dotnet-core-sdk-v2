using commercetools.Sdk.Api.Models.Searches;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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
