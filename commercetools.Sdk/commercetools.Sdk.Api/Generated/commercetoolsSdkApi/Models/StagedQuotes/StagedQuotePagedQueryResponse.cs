using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuotePagedQueryResponse : IStagedQuotePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IStagedQuote> Results { get; set; }

        public IEnumerable<IStagedQuote> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
