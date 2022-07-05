using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentPagedQueryResponse : IMyPaymentPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IMyPayment> Results { get; set; }
    }
}
