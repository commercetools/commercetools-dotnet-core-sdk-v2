using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestPagedQueryResponse))]
    public partial interface IQuoteRequestPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IQuoteRequest> Results { get; set; }

        IEnumerable<IQuoteRequest> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
