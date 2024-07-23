using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
