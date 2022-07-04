using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    public partial class QuoteRequestPagedQueryResponse : IQuoteRequestPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IQuoteRequest> Results { get; set; }
    }
}
