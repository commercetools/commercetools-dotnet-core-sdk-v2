using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class PaymentInfo : IPaymentInfo
    {
        public IList<IPaymentReference> Payments { get; set; }

        public IEnumerable<IPaymentReference> PaymentsEnumerable { set => Payments = value.ToList(); }
    }
}
