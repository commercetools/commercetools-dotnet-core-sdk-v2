using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    public partial class CustomerGroupPagedQueryResponse : ICustomerGroupPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<ICustomerGroup> Results { get; set; }
    }
}
