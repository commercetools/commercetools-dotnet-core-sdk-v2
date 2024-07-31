using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuotePagedQueryResponse))]
    public partial interface IStagedQuotePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IStagedQuote> Results { get; set; }

        IEnumerable<IStagedQuote> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
