using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerPagedQueryResponse : ICustomerPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ICustomer> Results { get; set; }
        public IEnumerable<ICustomer> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
