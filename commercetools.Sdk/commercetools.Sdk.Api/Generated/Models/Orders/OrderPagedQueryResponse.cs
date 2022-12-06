using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderPagedQueryResponse : IOrderPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IOrder> Results { get; set; }
        public IEnumerable<IOrder> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
