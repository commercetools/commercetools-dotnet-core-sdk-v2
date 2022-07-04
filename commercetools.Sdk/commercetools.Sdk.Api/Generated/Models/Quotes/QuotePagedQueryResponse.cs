using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Quotes
{
    public partial class QuotePagedQueryResponse : IQuotePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IQuote> Results { get; set; }
    }
}
