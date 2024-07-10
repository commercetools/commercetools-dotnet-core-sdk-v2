using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductPagedQueryResponse : IProductPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProduct> Results { get; set; }
        public IEnumerable<IProduct> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
