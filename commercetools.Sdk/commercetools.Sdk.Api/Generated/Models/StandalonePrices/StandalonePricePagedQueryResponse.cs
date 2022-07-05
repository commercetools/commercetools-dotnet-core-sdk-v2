using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePricePagedQueryResponse : IStandalonePricePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IStandalonePrice> Results { get; set; }
    }
}
