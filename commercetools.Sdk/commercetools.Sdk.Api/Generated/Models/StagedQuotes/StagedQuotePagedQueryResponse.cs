using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    public partial class StagedQuotePagedQueryResponse : IStagedQuotePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IStagedQuote> Results { get; set; }
    }
}
