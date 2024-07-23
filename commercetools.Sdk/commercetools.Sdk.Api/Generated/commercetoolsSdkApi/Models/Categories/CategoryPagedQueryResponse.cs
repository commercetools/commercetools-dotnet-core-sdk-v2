using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryPagedQueryResponse : ICategoryPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ICategory> Results { get; set; }
        public IEnumerable<ICategory> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
