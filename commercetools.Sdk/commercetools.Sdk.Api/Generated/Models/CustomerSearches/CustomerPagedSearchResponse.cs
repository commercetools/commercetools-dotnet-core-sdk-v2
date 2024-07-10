using commercetools.Sdk.Api.Models.CustomerSearches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
