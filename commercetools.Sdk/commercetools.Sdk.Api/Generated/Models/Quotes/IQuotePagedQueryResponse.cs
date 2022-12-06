using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuotePagedQueryResponse))]
    public partial interface IQuotePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IQuote> Results { get; set; }
        IEnumerable<IQuote> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
