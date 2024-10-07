using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodPagedQueryResponse : IShippingMethodPagedQueryResponse
    {
        public long? Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long? Offset { get; set; }

        public IList<IShippingMethod> Results { get; set; }

        public IEnumerable<IShippingMethod> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
