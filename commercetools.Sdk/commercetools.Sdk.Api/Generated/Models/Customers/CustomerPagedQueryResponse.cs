using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerPagedQueryResponse : ICustomerPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<ICustomer> Results { get; set; }
    }
}
