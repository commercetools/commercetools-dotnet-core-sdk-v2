using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentPagedQueryResponse : IPaymentPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IPayment> Results { get; set; }
        public IEnumerable<IPayment> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
