using commercetools.Api.Models.Payments;
using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class PaymentInfo : IPaymentInfo
    {
        public List<IPaymentReference> Payments { get; set;}
    }
}
