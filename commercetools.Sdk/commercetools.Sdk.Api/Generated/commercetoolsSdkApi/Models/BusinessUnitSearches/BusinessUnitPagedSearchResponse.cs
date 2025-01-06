using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{

    public partial class BusinessUnitPagedSearchResponse : IBusinessUnitPagedSearchResponse
    {
        public long Total { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public IList<IBusinessUnitSearchResult> Results { get; set; }

        public IEnumerable<IBusinessUnitSearchResult> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
