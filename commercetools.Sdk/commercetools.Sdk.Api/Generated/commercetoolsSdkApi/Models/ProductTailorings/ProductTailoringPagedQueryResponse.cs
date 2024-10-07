using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringPagedQueryResponse : IProductTailoringPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProductTailoring> Results { get; set; }

        public IEnumerable<IProductTailoring> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
