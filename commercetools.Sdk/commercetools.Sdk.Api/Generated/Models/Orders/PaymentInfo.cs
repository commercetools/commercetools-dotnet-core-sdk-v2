using commercetools.Sdk.Api.Models.Payments;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class PaymentInfo : IPaymentInfo
    {
        public List<IPaymentReference> Payments { get; set; }
    }
}
