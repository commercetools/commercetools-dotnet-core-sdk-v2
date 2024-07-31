using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryPagedQueryResponse : ITaxCategoryPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ITaxCategory> Results { get; set; }

        public IEnumerable<ITaxCategory> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
