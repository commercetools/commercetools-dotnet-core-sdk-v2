using commercetools.Sdk.Api.Models.Searches;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnitSearches.BusinessUnitSearchRequest))]
    public partial interface IBusinessUnitSearchRequest
    {
        ISearchQuery Query { get; set; }

        IList<ISearchSorting> Sort { get; set; }

        IEnumerable<ISearchSorting> SortEnumerable { set => Sort = value.ToList(); }

        int? Limit { get; set; }

        int? Offset { get; set; }

    }
}
