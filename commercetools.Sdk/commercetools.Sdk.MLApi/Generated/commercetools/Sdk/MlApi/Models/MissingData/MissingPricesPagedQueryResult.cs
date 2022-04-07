using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    public partial class MissingPricesPagedQueryResult : IMissingPricesPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public List<IMissingPrices> Results { get; set; }

        public IMissingPricesMeta Meta { get; set; }
    }
}
