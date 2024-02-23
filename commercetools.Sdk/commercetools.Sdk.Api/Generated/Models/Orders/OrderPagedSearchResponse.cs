using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderPagedSearchResponse : IOrderPagedSearchResponse
    {
        public long Total { get; set; }

        public long? Offset { get; set; }

        public long? Limit { get; set; }

        public IList<IHit> Hits { get; set; }
        public IEnumerable<IHit> HitsEnumerable { set => Hits = value.ToList(); }

    }
}
