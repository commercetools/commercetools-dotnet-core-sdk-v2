using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingPricesPagedQueryResult : IMissingPricesPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public IList<IMissingPrices> Results { get; set; }
        public IEnumerable<IMissingPrices> ResultsEnumerable { set => Results = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingPricesMeta Meta { get; set; }
    }
}
