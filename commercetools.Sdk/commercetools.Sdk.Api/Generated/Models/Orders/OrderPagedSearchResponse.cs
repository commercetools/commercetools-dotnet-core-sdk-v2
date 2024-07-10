using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
