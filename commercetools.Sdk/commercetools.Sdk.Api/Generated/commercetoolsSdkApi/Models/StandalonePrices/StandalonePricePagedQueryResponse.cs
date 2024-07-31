using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePricePagedQueryResponse : IStandalonePricePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IStandalonePrice> Results { get; set; }

        public IEnumerable<IStandalonePrice> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
