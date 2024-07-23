using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class PaymentInfo : IPaymentInfo
    {
        public IList<IReference> Payments { get; set; }
        public IEnumerable<IReference> PaymentsEnumerable { set => Payments = value.ToList(); }

    }
}
