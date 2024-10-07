using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditPagedQueryResponse : IOrderEditPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IOrderEdit> Results { get; set; }

        public IEnumerable<IOrderEdit> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
