using System.Collections.Generic;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class AssignedProductSelectionPagedQueryResponse : IAssignedProductSelectionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IAssignedProductSelection> Results { get; set; }
    }
}