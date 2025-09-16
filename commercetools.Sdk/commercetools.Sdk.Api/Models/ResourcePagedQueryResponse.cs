using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models
{

    public partial class ResourcePagedQueryResponse<T> : IResourcePagedQueryResponse<T>
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<T> Results { get; set; }

        public IEnumerable<T> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
