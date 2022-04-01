using System.Collections.Generic;
using commercetools.Sdk.Api.Models.Customers;

namespace commercetools.Sdk.Api.Serialization.Tests
{
    public class GraphResultData
    {
        public GraphCustomersResult Customers { get; set; }
    }
    public class GraphCustomersResult
    {
        public int Count { get; set; }
        public List<Customer> Results { get; set; }
    }
}