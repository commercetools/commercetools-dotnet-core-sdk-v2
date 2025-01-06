using commercetools.Sdk.Api.Models.Searches;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{

    public partial class BusinessUnitSearchRequest : IBusinessUnitSearchRequest
    {
        public ISearchQuery Query { get; set; }

        public IList<ISearchSorting> Sort { get; set; }

        public IEnumerable<ISearchSorting> SortEnumerable { set => Sort = value.ToList(); }

        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
