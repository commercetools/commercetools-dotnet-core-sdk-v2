using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderPagedQueryResponse : IRecurringOrderPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IRecurringOrder> Results { get; set; }

        public IEnumerable<IRecurringOrder> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
