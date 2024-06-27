using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.CustomerSearches
{

    public partial class CustomerPagedSearchResponse : ICustomerPagedSearchResponse
    {
        public long Total { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public IList<ICustomerSearchResult> Results { get; set; }
        public IEnumerable<ICustomerSearchResult> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
