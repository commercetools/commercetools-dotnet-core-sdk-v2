using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestPagedQueryResponse : IQuoteRequestPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IQuoteRequest> Results { get; set; }

        public IEnumerable<IQuoteRequest> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
