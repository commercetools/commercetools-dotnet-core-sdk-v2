using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodPagedQueryResponse : IPaymentMethodPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IPaymentMethod> Results { get; set; }

        public IEnumerable<IPaymentMethod> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
