using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductsInStorePagedQueryResponse : IProductsInStorePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProductSelectionAssignment> Results { get; set; }
        public IEnumerable<IProductSelectionAssignment> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
