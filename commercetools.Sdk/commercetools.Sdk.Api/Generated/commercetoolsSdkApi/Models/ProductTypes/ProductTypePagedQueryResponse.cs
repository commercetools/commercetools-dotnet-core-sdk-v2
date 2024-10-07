using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypePagedQueryResponse : IProductTypePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProductType> Results { get; set; }

        public IEnumerable<IProductType> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
