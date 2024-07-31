using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentPagedQueryResponse : IMyPaymentPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IMyPayment> Results { get; set; }

        public IEnumerable<IMyPayment> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
