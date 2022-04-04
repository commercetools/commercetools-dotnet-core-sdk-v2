using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderPagedSearchResponse : IOrderPagedSearchResponse
    {
        public long Total { get; set; }

        public long? Offset { get; set; }

        public long? Limit { get; set; }

        public List<IHit> Hits { get; set; }
    }
}
