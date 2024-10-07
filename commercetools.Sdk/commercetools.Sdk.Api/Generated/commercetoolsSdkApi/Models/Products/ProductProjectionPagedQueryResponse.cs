using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductProjectionPagedQueryResponse : IProductProjectionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IProductProjection> Results { get; set; }

        public IEnumerable<IProductProjection> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
