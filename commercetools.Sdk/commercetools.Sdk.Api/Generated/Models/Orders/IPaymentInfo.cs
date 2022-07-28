using commercetools.Sdk.Api.Models.Payments;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.PaymentInfo))]
    public partial interface IPaymentInfo
    {
        List<IPaymentReference> Payments { get; set; }

    }
}
