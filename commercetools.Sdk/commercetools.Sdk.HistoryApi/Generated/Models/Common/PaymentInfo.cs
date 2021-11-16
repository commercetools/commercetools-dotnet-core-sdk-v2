using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class PaymentInfo : IPaymentInfo
    {
        public List<IReference> Payments { get; set; }
    }
}
