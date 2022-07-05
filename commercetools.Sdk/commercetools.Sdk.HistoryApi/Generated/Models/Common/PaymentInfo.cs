using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class PaymentInfo : IPaymentInfo
    {
        public List<IReference> Payments { get; set; }
    }
}
