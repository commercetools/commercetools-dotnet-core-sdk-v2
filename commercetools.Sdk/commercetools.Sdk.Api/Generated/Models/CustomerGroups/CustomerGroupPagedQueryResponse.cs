using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroupPagedQueryResponse : ICustomerGroupPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ICustomerGroup> Results { get; set; }
        public IEnumerable<ICustomerGroup> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
