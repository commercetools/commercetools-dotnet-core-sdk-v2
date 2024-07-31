using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuotePagedQueryResponse : IQuotePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IQuote> Results { get; set; }

        public IEnumerable<IQuote> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
