using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnitSearches.BusinessUnitPagedSearchResponse))]
    public partial interface IBusinessUnitPagedSearchResponse
    {
        long Total { get; set; }

        int Limit { get; set; }

        int Offset { get; set; }

        IList<IBusinessUnitSearchResult> Results { get; set; }

        IEnumerable<IBusinessUnitSearchResult> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
