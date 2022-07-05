using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionPagedQueryResponse : IProductSelectionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IProductSelection> Results { get; set; }
    }
}
