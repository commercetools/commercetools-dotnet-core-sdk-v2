using commercetools.Api.Models.Payments;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        List<IPaymentReference> Payments { get; set; }
    }
}
