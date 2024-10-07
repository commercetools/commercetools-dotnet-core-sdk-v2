using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionProductPagedQueryResponse : IProductSelectionProductPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IAssignedProductReference> Results { get; set; }

        public IEnumerable<IAssignedProductReference> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
